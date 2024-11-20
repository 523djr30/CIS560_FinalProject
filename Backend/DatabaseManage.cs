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
    public static Table? QueryText(string sql) => DatabaseConnect.QueryText(sql);
    public static Table? QueryFile(string sql) => DatabaseConnect.QueryFile(sql);
    public static void PrintTable(Table? table) => DatabaseConnect.PrintTable(table);
}