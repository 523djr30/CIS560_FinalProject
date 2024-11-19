using System;

namespace Backend;


//Initializes database
internal static class DatabaseSetup
{
    public static void SetupDB()=> ForceSetupDB();
    public static void ForceSetupDB()
    {
        CreateTables();
    } 
    
    private static void CreateTables()
    {
        int r;
        r = DatabaseConnect.RunDmlFile("CreateTables");
        r = DatabaseConnect.RunDmlFile("CreateTestData");
        Console.WriteLine(r);
    }
}