using System;
using System.IO;
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
        return s.ConnectionContext.ExecuteNonQuery(sql);
    }

    public static int RunDmlFile(string filename)
    {
        string sql = File.ReadAllText("../../../../Backend/"+filename+".sql");
        return RunDmlText(sql);
    }
}