namespace Backend;


//For the other programs to use
public static class DatabaseManage
{
    public static void SetupDB() => DatabaseSetup.SetupDB();
    public static object[][] Query(string sql) => DatabaseConnect.Query(sql);
    public static object[][] QueryAndPrint(string sql) => DatabaseConnect.QueryAndPrint(sql);
}