using System;
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
    private static string PathToBackend = "../../../../Backend";

    static DatabaseConnect()
    {
        PathToBackend = "Backend";
        for (int i = 0; i < 5; i++)
        {
            if(Directory.Exists(PathToBackend)) return;
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
        string sql = File.ReadAllText("../../../../Backend/"+filename+".sql");
        return RunDmlText(sql);
    }
    
    //prefix dates with a !, like "!2024-11-18"
    public static int InsertRows(string tableName, string colNames, object[][] data)
    {
        StringBuilder sb = new();
        sb.Append("Insert into Football.").Append(tableName).Append('(').Append(colNames).Append(")\nValues");
        bool firstCol,firstRow = true;
        foreach (object[] row in data)
        {
            sb.Append(firstRow ? "\n(" : ",\n(");
            firstRow = false;
            firstCol = true;
            foreach (object d in row)
            {
                if (d is int dI)
                    sb.Append(dI);                                  //int
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
}