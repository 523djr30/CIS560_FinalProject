namespace Backend;

/*Example usage
using Backend;

DatabaseManage.SetupDB();
DatabaseManage.PrintTable(DatabaseManage.QueryFile("SampleQuery"));


*/

//For the other programs to use
public static class DatabaseManage
{
    public static void SetupDB() => DatabaseSetup.SetupDB();
    public static object[][]? QueryText(string sql) => DatabaseConnect.QueryText(sql);
    public static object[][]? QueryFile(string sql) => DatabaseConnect.QueryFile(sql);
    public static void PrintTable(object[][]? table) => DatabaseConnect.PrintTable(table);
}