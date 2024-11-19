using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Common;

namespace Backend;

//Handles actual connecting to the SQL database
internal static class DatabaseConnect
{
    private const string ConnectionString = "Server=(localdb)\\MSSQLLocalDB; Integrated Security=true";
    private static readonly string PathToBackend;

    static DatabaseConnect()
    {
        //TODO: this is kinda hacky, but works fine for now
        PathToBackend = "Backend";
        for (int i = 0; i < 5; i++)
        {
            if (Directory.Exists(PathToBackend)) return;
            PathToBackend = "../" + PathToBackend;
        }
    }

    private static SqlConnection Connect() => new(ConnectionString);

    public static int RunDmlText(string sql)
    {
        using var con = Connect();
        Server s = new(new ServerConnection(con));
        int r = s.ConnectionContext.ExecuteNonQuery(sql);
        Console.WriteLine(r + " rows affected");
        return r;
    }

    public static int RunDmlFile(string filename)
    {
        string sql = File.ReadAllText(PathToBackend+'\\' + filename + ".sql");
        return RunDmlText(sql);
    }

    //prefix dates with a !, like "!2024-11-18"
    public static int InsertRows(string tableName, string colNames, object[][] data)
    {
        StringBuilder sb = new();
        sb.Append("Insert into Football.").Append(tableName).Append('(').Append(colNames).Append(")\nValues");
        bool firstCol, firstRow = true;
        foreach (object[] row in data)
        {
            sb.Append(firstRow ? "\n(" : ",\n(");
            firstRow = false;
            firstCol = true;
            foreach (object d in row)
            {
                if (d is int dI)
                    sb.Append(dI); //int
                else if (d is string dS)
                {
                    if (!firstCol)
                        sb.Append(',');
                    firstCol = false;
                    if (dS.Length > 0 && dS[0] == '!')
                        sb.Append('\'').Append(dS.Substring(1)); //date
                    else
                        sb.Append("N\'").Append(dS); //string
                    sb.Append('\'');
                }
            }

            sb.Append(')');
        }

        sb.Append(";\nGO");
        // Console.WriteLine(sb);
        return RunDmlText(sb.ToString());
        // return -1;
    }


    //array of rows, where each row is an array of data returned from the query
    public static object[][]? Query(string sql)
    {
        object[][]? r = null;
        try
        {
            List<object[]> ret = [];
            using var con = Connect();
            using SqlCommand command = new(sql, con);
            con.Open();
            using SqlDataReader reader = command.ExecuteReader();

            int columns = reader.GetColumnSchema().Count;

            while (reader.Read())
            {
                object[] row = new object[columns];
                reader.GetValues(row);
                ret.Add(row);
            }

            r = ret.ToArray();
        }
        catch (SqlException e)
        {
            Console.WriteLine(e.ToString());
        }

        return r;
    }

    public static object[][]? QueryAndPrint(string sql)
    {
        object[][]? r = Query(sql);
        Console.WriteLine("\n+---Querry Result---");
        if (r != null)
            foreach (var row in r)
            {
                Console.Write("| ");
                foreach (object data in row)
                    Console.Write(data + ", ");
                Console.WriteLine();
            }

        Console.WriteLine("+-------------------\n");
        return r;
    }
}