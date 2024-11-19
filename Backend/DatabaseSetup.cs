using System;

namespace Backend;

using static DatabaseConnect;

//Initializes database
internal static class DatabaseSetup
{
    //function since we may not want to re setup the tables every single time.
    public static void SetupDB() => ForceSetupDB();


    public static void ForceSetupDB()
    {
        CreateTables();
        ExamplePopulateTable();
        // PopulateAllTables();
    }

    private static void CreateTables() => RunDmlFile("CreateTables");


    //example of how to populate a table
    private static int ExamplePopulateTable() => InsertRows("Team", "Name,State", [
        ["Wildcats", "Kansas"],
        ["Fried Chickens", "Kentucky"],
        ["Cheese Burgers", "Colorado"],
        ["Jayhawks", "Kansas"]
    ]);


    //list of functions to call in order to populate tables
    private static Func<int>[] PopulateMethods =
    [
        PopulatePositions,
        PopulateTeam,
        PopulateDivision,
        PopulatePlayer,
        PopulateSeason,
        PopulateDivisionMembership,
        PopulatePlayerTeamHistory,
        PopulateStadium,
        PopulateMatch,
        PopulatePlayerMatchStats
    ];

    //calls all the other populate functions in the correct order and checks rows affected
    private static int PopulateAllTables()
    {
        int sum = 0;
        foreach (var func in PopulateMethods)
        {
            int affectedRows = func.Invoke();
            if (affectedRows <= 0)
                Console.WriteLine("Table may not have been populated");
            sum += affectedRows;
        }

        Console.WriteLine(sum + " total rows affected");
        return sum;
    }


    //per table populations.
    private static int PopulatePositions()=>0;          //TODO: not implemented.
    private static int PopulateTeam()=>0;               //TODO: not implemented.
    private static int PopulateDivision()=>0;           //TODO: not implemented.
    private static int PopulatePlayer()=>0;             //TODO: not implemented.
    private static int PopulateSeason()=>0;             //TODO: not implemented.
    private static int PopulateDivisionMembership()=>0; //TODO: not implemented.
    private static int PopulatePlayerTeamHistory()=>0;  //TODO: not implemented.
    private static int PopulateStadium()=>0;            //TODO: not implemented.
    private static int PopulateMatch()=>0;              //TODO: not implemented.
    private static int PopulatePlayerMatchStats()=>0;   //TODO: not implemented.
}