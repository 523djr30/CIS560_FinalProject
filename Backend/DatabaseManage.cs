namespace Backend;

/*Example usage

using Backend;

DatabaseManage.SetupDB();
Table? t = DatabaseManage.QueryFile("SampleQuery");
DatabaseManage.PrintTable(t);

if (t != null)
{
    foreach (Row r in t)
    {
        int id = r.Int["TeamId"];
        string name = r.Str["Name"];

        Console.WriteLine(id + ": " + name);
    }
}

*/

//For the other programs to use
public static class DatabaseManage
{
    public static void SetupDB() => DatabaseSetup.SetupDB();
    public static void ForceSetupDB() => DatabaseSetup.ForceSetupDB();
    public static Table? QueryText(string sql) => DatabaseConnect.QueryText(sql);
    public static Table? QueryFile(string sql) => DatabaseConnect.QueryFile(sql);
    public static Table? QueryFileText(string sql, string file) => DatabaseConnect.QueryTextPlusFile(sql,file);
    public static int InsertRows(string tableName, string colNames, object[][] data) => DatabaseConnect.InsertRows(tableName, colNames, data);

    public static int RunDmlFileWithValueTable(string colNames, object[][] data, string filename) =>
        DatabaseConnect.RunDmlFileWithValueTable(colNames, data, filename);
    public static int RunDmlText(string sql) => DatabaseConnect.RunDmlText(sql);
}