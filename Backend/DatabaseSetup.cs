using System;
using System.Collections.Generic;
using static Backend.FileManager.PlayerMatchData;

namespace Backend;

using static DatabaseConnect;

//Initializes database
public static class DatabaseSetup
{
    //function since we may not want to re setup the tables every single time.
    public static void SetupDB()
    {
        Table? testTable = null;
        try
        {
            testTable = DatabaseManage.QueryText("Select count(*) from Football.PlayerMatchStats");
        }
        catch (Exception _)
        {
        }

        int count = 0;
        if (testTable != null)
            count = testTable[0].Int[""];
        if (count == 0)
        {
            Console.WriteLine("No data found in DB, setting up");
            ForceSetupDB();
        }
        else
            Console.WriteLine("Already set up, skipping setup...");

        testTable = DatabaseManage.QueryText("Select count(*) from Football.Season");
        count = 0;
        if (testTable != null)
            count = testTable[0].Int[""];
        if (count == 0)
        {
            Console.WriteLine("No data found in Seasons, setting up");
            PopulateSeason();
        }
        else
            Console.WriteLine("Season Already set up, skipping setup...");
    }


    public static void ForceSetupDB()
    {
        DateTime start = DateTime.Now;
        CreateTables();
        PopulateAllTables();
        FileManager.FreeMemoryHog();
        double timediff = Math.Floor((DateTime.Now - start).TotalMinutes);
        double timediff_sec = (DateTime.Now - start).Seconds;
        Console.WriteLine("Done, total time taken is "+timediff+":"+timediff_sec);
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
            Console.WriteLine(affectedRows + " rows affected by " + func.Method.Name);
            sum += affectedRows;
        }

        Console.WriteLine(sum + " total rows affected");
        return sum;
    }


    //per table populations.
    private static int PopulatePositions() => InsertRows("Positions", "ShortName,Name", [
        ["QB", "Quarterback"],
        ["RB", "Running Back"],
        ["WR", "Wide Receiver"],
        ["TE", "Tight End"],
        ["OL", "Offensive Lineman"],
        ["DL", "Defensive Lineman"],
        ["LB", "Linebacker"],
        ["CB", "Cornerback"],
        ["S", "Safety"],
        ["K", "Kicker"],
        ["P", "Punter"]
    ]);

    private static int PopulateTeam() => InsertRows("Team", "State,City,Name", [
        ["State Unknown", "Buffalo", "Bills"],
        ["State Unknown", "Miami", "Dolphins"],
        ["State Unknown", "New England", "Patriots"],
        ["State Unknown", "New York", "Jets"],
        ["State Unknown", "Baltimore", "Ravens"],
        ["State Unknown", "Cincinnati", "Bengals"],
        ["State Unknown", "Cleveland", "Browns"],
        ["State Unknown", "Pittsburgh", "Steelers"],
        ["State Unknown", "Houston", "Texans"],
        ["State Unknown", "Indianapolis", "Colts"],
        ["State Unknown", "Jacksonville", "Jaguars"],
        ["State Unknown", "Tennessee", "Titans"],
        ["State Unknown", "Denver", "Broncos"],
        ["State Unknown", "Kansas City", "Chiefs"],
        ["State Unknown", "Las Vegas", "Raiders"],
        ["State Unknown", "Los Angeles", "Chargers"],
        ["State Unknown", "Dallas", "Cowboys"],
        ["State Unknown", "New York", "Giants"],
        ["State Unknown", "Philadelphia", "Eagles"],
        ["State Unknown", "Washington", "Commanders"],
        ["State Unknown", "Chicago", "Bears"],
        ["State Unknown", "Detroit", "Lions"],
        ["State Unknown", "Green Bay", "Packers"],
        ["State Unknown", "Minnesota", "Vikings"],
        ["State Unknown", "Atlanta", "Falcons"],
        ["State Unknown", "Carolina", "Panthers"],
        ["State Unknown", "New Orleans", "Saints"],
        ["State Unknown", "Tampa Bay", "Buccaneers"],
        ["State Unknown", "Arizona", "Cardinals"],
        ["State Unknown", "Los Angeles", "Rams"],
        ["State Unknown", "San Francisco", "49ers"],
        ["State Unknown", "Seattle", "Seahawks"]
    ]);

    private static int PopulateDivision() => InsertRows("Division", "Name", [
        ["AFC NORTH"],
        ["AFC EAST"],
        ["AFC SOUTH"],
        ["AFC WEST"],
        ["NFC NORTH"],
        ["NFC EAST"],
        ["NFC SOUTH"],
        ["NFC WEST"]
    ]);

    private static int PopulatePlayer()
    {
        Console.WriteLine("Processing Profiles");
        List<FileManager.PlayerProfile> profiles = FileManager.GetPlayerProfiles();
        object[][] data = new object[profiles.Count][];
        for (int i = 0; i < profiles.Count; i++)
        {
            FileManager.PlayerProfile p = profiles[i];
            data[i] = [p.player_id, p.FirstName, p.LastName, p.bio];
        }

        return InsertRows("Player", "PlayerId,FirstName,LastName,Bio", data);
    }


//TODO: This is still temporary
    private static int PopulateSeason()
    {
        List<object[]> data = [];
        for (int i = 1900; i < 2100; i++)
        {
            data.Add([
                i,
                "!" + i + "-08-01",
                "!" + (i + 1) + "-01-01",
                "!" + (i + 1) + "-07-31",
            ]);
        }

        return InsertRows("Season", "SeasonId,StartDate,PlayoffsDate,EndDate", data.ToArray());
    }

    private static int PopulateDivisionMembership() => RunDmlFile("PopulateDivisionMemberships");


    private static int compareDateToRange(string date, (string, string) range)
    {
        (string a, string b) = range;
        if (date.CompareTo(a) < 0) //date before range, -1
            return -1;
        if (date.CompareTo(b) > 0) //date after range, 1
            return 1;
        return 0;
    }

    private static void insertToParticipationList(List<((string, string), string)> list, string date, string team)
    {
        if (list.Count == 0)
        {
            list.Add(((date, date), team));
            return;
        }

        ((string, string), string)? preceeding = null, intersecting = null, after = null, tmp;
        int preIndex = 0, intersectIndex = 0, afterIndex = 0;
        for (int i = 0; i < list.Count; i++)
        {
            tmp = list[i];
            ((string, string) range, _) = (((string, string), string))tmp;

            int comp = compareDateToRange(date, range);
            if (comp == 1)
            {
                //date after range
                preceeding = tmp;
                preIndex = i;
            }

            else if (comp == -1)
            {
                after = tmp;
                afterIndex = i;
                break;
            }
            else
            {
                intersecting = tmp;
                intersectIndex = i;
                break;
            }
        }

        if (intersecting != null)
        {
            ((string a, string b), string team2) = (((string, string), string))intersecting;
            if (!team.Equals(team2))
            {
                list[intersectIndex] = ((a, date), team2);
                list.InsertRange(intersectIndex + 1, [((date, date), team), ((b, b), team2)]);
                return;
            }

            return;
        }

        if (preceeding != null)
        {
            ((string a, string b), string team2) = (((string, string), string))preceeding;
            if (team.Equals(team2))
            {
                list[intersectIndex] = ((a, date), team);
                return;
            }
        }

        if (after != null)
        {
            ((string a, string b), string team2) = (((string, string), string))after;
            if (team.Equals(team2))
            {
                list[afterIndex] = ((date, b), team);
                return;
            }
            else
            {
                list.Insert(afterIndex, ((date, date), team));
                return;
            }
        }

        list.Add(((date, date), team));
    }

    private static void deduplicateParticipationList(List<((string, string), string)> list)
    {
        if (list.Count > 1)
        {
            ((string aRef, string bRef), string teamRef) = list[^1];
            bool duplicated = false;
            for (int i = list.Count - 2; i >= 0; i--)
            {
                ((string a, string b), string team) = list[i];
                if (a.Equals(aRef) && team.Equals(teamRef))
                {
                    list.RemoveAt(list.Count - 1);
                    return;
                }
            }
        }
    }

    private static int PopulatePlayerTeamHistory()
    {
        List<FileManager.PlayerMatchData> dataList = FileManager.GetPlayerMatchStats();
        Dictionary<int, List<((string, string), string)>> participationLists = [];

        foreach (FileManager.PlayerMatchData d in dataList)
        {
            if (!participationLists.ContainsKey(d.player_id))
                participationLists[d.player_id] = [];
            List<((string, string), string)>
                p = participationLists[d.player_id]; //match participation list is date range, team played for
            insertToParticipationList(p, d.date, d.team);
            deduplicateParticipationList(p); //cant be bothered to fix this properly right now
        }

        List<object[]> data = [];
        foreach (var kvp in participationLists)
        {
            int playerId = kvp.Key;
            List<((string, string), string)> p = kvp.Value;
            foreach (var membership in p)
            {
                ((string startDate, string endDate), string teamShort) = membership;

                //PlayerId,TeamName,StartDate,EndDate
                if (FileManager.ValidAbbreviation(teamShort))
                    data.Add([playerId, FileManager.DeAbbreviateTeam(teamShort), '!' + startDate, '!' + endDate]);
            }
        }


        return RunDmlFileWithValueTable("PlayerId,TeamName,StartDate,EndDate", data.ToArray(),
            "PopulatePlayerTeamMembership");
    }

    private static int PopulateStadium() => RunDmlFile("PopulateStadiums");

    private static int PopulateMatch()
    {
        List<FileManager.PlayerMatchData> dataList = FileManager.GetPlayerMatchStats();
        Dictionary<string, List<(string, string)>> matchesByDate = []; //key date, list of home team, away team

        foreach (FileManager.PlayerMatchData d in dataList)
        {
            if (!matchesByDate.ContainsKey(d.date))
                matchesByDate[d.date] = [];
            List<(string, string)> matches = matchesByDate[d.date];
            (string, string) match;
            if (d.game_location == 'H')
                match = (d.team, d.opponent);
            else
                match = (d.opponent, d.team);

            bool matchPresent = false;
            foreach (var m in matches)
                if (match.Item1.Equals(m.Item1) && match.Item2.Equals(m.Item2))
                {
                    matchPresent = true;
                    break;
                }

            if (!matchPresent)
                matches.Add(match);
        }

        List<object[]> data = [];
        foreach (var kvp in matchesByDate)
        {
            string date = kvp.Key;
            List<(string, string)> m = kvp.Value;
            foreach (var membership in m)
            {
                (string home, string away) = membership;

                //Date,HomeTeamId,AwayTeamId
                if (FileManager.ValidAbbreviation(home) && FileManager.ValidAbbreviation(away))
                    data.Add(['!' + date, FileManager.DeAbbreviateTeam(home), FileManager.DeAbbreviateTeam(away)]);
            }
        }

        return RunDmlFileWithValueTable("Date,HomeTeamName,AwayTeamName", data.ToArray(), "PopulateMatches");
    }

    private static int PopulatePlayerMatchStats()
    {
        Console.WriteLine("Populating match stats, this will take a while");
        List<FileManager.PlayerMatchData> dataList = FileManager.GetPlayerMatchStats();

        List<object[]> data = [];
        
        foreach (var row in dataList)
        {
            //PlayerId,TeamName,Date,Yards,Points

            if (FileManager.ValidAbbreviation(row.team))
                data.Add([
                    row.player_id,
                    FileManager.DeAbbreviateTeam(row.team),
                    '!' + row.date,
                    row.rushing_yards,
                    row.player_team_score
                ]);
        }

        return RunDmlFileWithValueTable("PlayerId,TeamName,Date,Yards,Points", data.ToArray(),
            "PopulatePlayerMatchStats");
    }
}