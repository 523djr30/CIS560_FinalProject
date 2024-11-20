using System;
using System.Collections.Generic;
using System.Data.Common;
using System.IO;
using System.Text;
using Microsoft.Data.SqlClient;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Common;

namespace Backend;

//Handles actual connecting to the SQL database
internal static class DatabaseConnect
{
    private const string ConnectionString = "Server=(localdb)\\MSSQLLocalDB; Integrated Security=true";

    public static string Sanitize(string s)
    {
        return s.Replace('\'', ' ').Replace('\"', ' ');
    }

    public static T CallWithFile<T>(Func<string, T> func, string filename)
    {
        string sql = File.ReadAllText(FileManager.SqlPath + filename + ".sql");
        return func.Invoke(sql);
    }

    public static void SaveSql(string filename, string sql) =>
        File.WriteAllText(FileManager.SqlPath + filename + ".sql", sql);

    private static SqlConnection Connect() => new(ConnectionString);

    public static int RunDmlText(string sql)
    {
        // Console.WriteLine(sql);
        using var con = Connect();
        Server s = new(new ServerConnection(con));
        int r = s.ConnectionContext.ExecuteNonQuery(sql);
        // Console.WriteLine(r + " rows affected");
        return r;
    }

    public static int RunDmlFile(string filename) => CallWithFile(RunDmlText, filename);

    
    public static int ChunkifyOperation(Func<object[][],int> op,object[][] data, int chunkSize)
    {
        int sum = 0;
        for (int i = 0; i < data.Length;)
        {
            int nextI = Math.Min(i + chunkSize,data.Length);
            sum+=op.Invoke(data[i..(nextI-1)]);
            i = nextI;
        }

        return sum;
    }
    
    
    public static string RunDmlTextWithValueTableSqlGen(string colNames, object[][] data, string sql) =>
        "With ValueTable as (Select * from (" + ValuesSqlGen(data) + ") as v ("+colNames+"))" + sql;
    
    public static int RunDmlTextWithValueTable(string colNames, object[][] data, string sql)
    {
        if (data.Length > 500)
            return ChunkifyOperation((d)=>RunDmlTextWithValueTable(colNames,d,sql),data,500);
        
        return RunDmlText(RunDmlTextWithValueTableSqlGen(colNames,data,sql));
    }

    public static int RunDmlFileWithValueTable(string colNames, object[][] data, string filename)
    {
        string sql = File.ReadAllText(FileManager.SqlPath + filename + ".sql");
        return RunDmlTextWithValueTable(colNames, data, sql);
    }
    
   
    
    public static string InsertRowsSqlGen(string tableName, string colNames, object[][] data) =>
        "Insert into Football." + tableName + '(' + colNames + ")\n" + ValuesSqlGen(data) + ";\nGO\n";

    public static int InsertRows(string tableName, string colNames, object[][] data)
    {
        if (data.Length > 500)
            return ChunkifyOperation((d)=>InsertRows(tableName,colNames,d),data,500);
        return RunDmlText(InsertRowsSqlGen(tableName, colNames, data));
    }

    //prefix dates with a !, like "!2024-11-18"
    public static string ValuesSqlGen(object[][] data)
    {
        StringBuilder sb = new("Values\n");
        bool firstRow = true;
        foreach (object[] row in data)
        {
            sb.Append(firstRow ? "\n(" : ",\n(");
            firstRow = false;
            bool firstCol = true;
            foreach (object d in row)
            {
                if (!firstCol)
                    sb.Append(',');
                firstCol = false;

                if (d is int dI)
                    sb.Append(dI); //int
                else if (d is string dS)
                {
                    if (dS.Length > 0 && dS[0] == '!')
                        sb.Append('\'').Append(dS.Substring(1)); //date
                    else
                        sb.Append("N\'").Append(dS); //string
                    sb.Append('\'');
                }
            }

            sb.Append(')');
        }

        return sb.ToString();
    }

    


    //array of rows, where each row is an array of data returned from the query
    public static Table? QueryText(string sql)
    {
        try
        {
            List<object[]> ret = [];
            using var con = Connect();
            using SqlCommand command = new(sql, con);
            con.Open();
            using SqlDataReader reader = command.ExecuteReader();

            var cols = reader.GetColumnSchema();
            if (cols == null)
                return null;

            while (reader.Read())
            {
                object[] row = new object[cols.Count];
                reader.GetValues(row);
                ret.Add(row);
            }

            Dictionary<string, (Type, int)> colDict = [];
            foreach (DbColumn col in cols)
            {
                if (col.ColumnOrdinal != null && col.DataType != null)
                    colDict[col.ColumnName] = ((Type, int))(col.DataType, col.ColumnOrdinal);
            }

            return new Table(ret.ToArray(), colDict);
        }
        catch (SqlException e)
        {
            Console.WriteLine(e.ToString());
        }

        return null;
    }

    public static Table? QueryFile(string filename) => CallWithFile(QueryText, filename);


    public static void PrintTable(Table? table)
    {
        Console.WriteLine("\n+---Querry Result---");
        if (table != null)
            foreach (var row in table.Data)
            {
                Console.Write("| ");
                foreach (object data in row.Data)
                    Console.Write(data + ", ");
                Console.WriteLine();
            }

        Console.WriteLine("+-------------------\n");
    }
}