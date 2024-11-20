using System;
using System.Collections.Generic;

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
        // ExamplePopulateTable();
        PopulateAllTables();
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
            Console.WriteLine(affectedRows+" rows affected by "+func.Method.Name);
            sum += affectedRows;
        }

        Console.WriteLine(sum + " total rows affected");
        return sum;
    }


    //per table populations.
    private static int PopulatePositions()=>InsertRows("Positions","ShortName,Name",[
        ["QB","Quarterback"],
        ["RB","Running Back"],
        ["WR","Wide Receiver"],
        ["TE","Tight End"],
        ["OL","Offensive Lineman"],
        ["DL","Defensive Lineman"],
        ["LB","Linebacker"],
        ["CB","Cornerback"],
        ["S","Safety"],
        ["K","Kicker"],
        ["P","Punter"]
    ]);
    
    private static int PopulateTeam()=>InsertRows("Team","State,Name",[
        ["State Unknown","Buffalo Bills"],
        ["State Unknown","Miami Dolphins"],
        ["State Unknown","New England Patriots"],
        ["State Unknown","New York Jets"],
        ["State Unknown","Baltimore Ravens"],
        ["State Unknown","Cincinnati Bengals"],
        ["State Unknown","Cleveland Browns"],
        ["State Unknown","Pittsburgh Steelers"],
        ["State Unknown","Houston Texans"],
        ["State Unknown","Indianapolis Colts"],
        ["State Unknown","Jacksonville Jaguars"],
        ["State Unknown","Tennessee Titans"],
        ["State Unknown","Denver Broncos"],
        ["State Unknown","Kansas City Chiefs"],
        ["State Unknown","Las Vegas Raiders"],
        ["State Unknown","Los Angeles Chargers"],
        ["State Unknown","Dallas Cowboys"],
        ["State Unknown","New York Giants"],
        ["State Unknown","Philadelphia Eagles"],
        ["State Unknown","Washington Commanders"],
        ["State Unknown","Chicago Bears"],
        ["State Unknown","Detroit Lions"],
        ["State Unknown","Green Bay Packers"],
        ["State Unknown","Minnesota Vikings"],
        ["State Unknown","Atlanta Falcons"],
        ["State Unknown","Carolina Panthers"],
        ["State Unknown","New Orleans Saints"],
        ["State Unknown","Tampa Bay Buccaneers"],
        ["State Unknown","Arizona Cardinals"],
        ["State Unknown","Los Angeles Rams"],
        ["State Unknown","San Francisco 49ers"],
        ["State Unknown","Seattle Seahawks"]
    ]);
    
    private static int PopulateDivision()=>InsertRows("Division","Name",[
        ["AFC NORTH"],
        ["AFC EAST"],
        ["AFC SOUTH"],
        ["AFC WEST"]
    ]);

    private static int PopulatePlayer()
    {
        Console.WriteLine("Processing Profiles");
        List<FileManager.PlayerProfile> profiles = FileManager.GetPlayerProfiles();
        object[][] data = new object[profiles.Count][];
        for (int i = 0; i < profiles.Count; i++)
        {
            FileManager.PlayerProfile p = profiles[i];
            data[i] = [p.player_id, p.FirstName,p.LastName,p.bio];
        }

        return InsertRows("Player", "PlayerId,FirstName,LastName,Bio",data);
    }
    private static int PopulateSeason()=> 0;
    private static int PopulateDivisionMembership()=>0; //TODO: not implemented.
    private static int PopulatePlayerTeamHistory()=>0;  //TODO: not implemented.
    private static int PopulateStadium()=>RunDmlFile("PopulateStadiums");
    private static int PopulateMatch()=>0;              //TODO: not implemented.
    private static int PopulatePlayerMatchStats()=>0;   //TODO: not implemented.
}