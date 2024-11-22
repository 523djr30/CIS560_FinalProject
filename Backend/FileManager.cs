using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace Backend;

internal static class FileManager
{
    public static readonly string BackendPath;
    public static string SqlPath => BackendPath + "/SQL/";
    public static string DataPath => BackendPath + "/Data/";

    static FileManager()
    {
        //TODO: this is kind of a hacky way to find the folder with the SQL files,
        //      but it works fine for now
        BackendPath = "Backend";
        for (int i = 0; i < 5; i++)
        {
            if (Directory.Exists(BackendPath)) return;
            BackendPath = "../" + BackendPath;
        }
        // BackendPath = "C:/Users/Shay/ShaySpace/School/CIS 560/CIS560_FinalProject/Backend";
    }

    private static Dictionary<string, string> TeamAbbreviations = new()
    {
        { "ARZ", "Cardinals" },
        { "ARI", "Cardinals" },
        { "ATL", "Falcons" },
        { "BLT", "Ravens" },
        { "BAL", "Ravens" },
        { "BUF", "Bills" },
        { "CAR", "Panthers" },
        { "CHI", "Bears" },
        { "CIN", "Bengals" },
        { "CLV", "Browns" },
        { "CLE", "Browns" },
        { "DAL", "Cowboys" },
        { "DEN", "Broncos" },
        { "DET", "Lions" },
        { "GB", "Packers" },
        { "HST", "Texans" },
        { "HOU", "Texans" },
        { "IND", "Colts" },
        { "JAX", "Jaguars" },
        { "JAC", "Jaguars" },
        { "KC", "Chiefs" },
        { "LV", "Raiders" },
        { "LAC", "Chargers" },
        { "LA", "Rams" },
        { "LAR", "Rams" },
        { "MIA", "Dolphins" },
        { "MIN", "Vikings" },
        { "NE", "Patriots" },
        { "NO", "Saints" },
        { "NYG", "Giants" },
        { "NYJ", "Jets" },
        { "PHI", "Eagles" },
        { "PIT", "Steelers" },
        { "SF", "49ers" },
        { "SEA", "Seahawks" },
        { "TB", "Buccaneers" },
        { "TEN", "Titans" },
        { "WAS", "Commanders" },
    };

    public static bool ValidAbbreviation(string s) => TeamAbbreviations.ContainsKey(s);
    public static string DeAbbreviateTeam(string s) => TeamAbbreviations[s];
    public static string TeamOf(PlayerMatchData d) => TeamAbbreviations[d.team];


    private static string ReadJsonFile(string filename)
    {
        using StreamReader r = new StreamReader(DataPath + filename + ".json");
        return r.ReadToEnd();
    }

    internal class PlayerProfile
    {
        public int player_id;
        public string Name;
        public string birth_date, height, weight;

        public string FirstName, LastName, TeamName;
        public string bio = ""; //TODO fluff out
    }

    public static List<PlayerProfile> GetPlayerProfiles()
    {
        string json = ReadJsonFile("profiles");
        List<PlayerProfile>? biosList = JsonConvert.DeserializeObject<List<PlayerProfile>>(json);
        if(biosList!=null)
            foreach (PlayerProfile p in biosList)
            {
                int split = p.Name.IndexOf(' ');
                if (split == -1)
                {
                    p.FirstName = p.Name.Trim();
                    p.LastName = "";
                }
                else
                {
                    p.FirstName = DatabaseConnect.Sanitize(p.Name.Substring(0, split));
                    p.LastName = DatabaseConnect.Sanitize(p.Name.Substring(1 + split));
                }

                p.bio = "Born: " + p.birth_date +
                        "    Height: " + p.height +
                        "    Weight: " + p.weight; //TODO potentially more biographical data
            }

        return biosList;
    }

    public class PlayerMatchData
    {
        //{"player_id": 1809,
        //"date": "1990-09-09", "age": "23-120"
        //"team": "SEA"
        //"game_location": "A"
        //"opponent": "CHI", "game_won": false,
        //"player_team_score": "0",
        //"passing_attempts": 0, "passing_completions": 0, "passing_yards": 0, "passing_rating": 0, "passing_touchdowns": 0, "passing_interceptions": 0, "passing_sacks": 0, "passing_sacks_yards_lost": 0,
        //"rushing_attempts": 0, "rushing_yards": 0, "rushing_touchdowns": 0, "receiving_targets": 0, "receiving_receptions": 0, "receiving_yards": 0, "receiving_touchdowns": 0, "kick_return_attempts": 0, "kick_return_yards": 0, "kick_return_touchdowns": 0, "punt_return_attempts": 0, "punt_return_yards": 0, "punt_return_touchdowns": 0, "defense_sacks": 0, "defense_tackles": 0, "defense_tackle_assists": 0, "defense_interceptions": 0, "defense_interception_yards": 0, "defense_interception_touchdowns": 0, "defense_safeties": 0, "point_after_attemps": 0, "point_after_makes": 0, "field_goal_attempts": 0, "field_goal_makes": 0, "punting_attempts": 0, "punting_yards": 0, "punting_blocked": 0}
        public string team, opponent;
        public string date;
        public char game_location; //H or A for home/away
        public int player_id, player_team_score,rushing_yards;
    }


    private const int matchDataLimit = int.MaxValue;//4000; //TODO set to int max after testing
    private static List<PlayerMatchData>? playerMatchStats = null;
    
    public static List<PlayerMatchData> GetPlayerMatchStats()
    {
        using StreamReader r = new StreamReader(DataPath + "games.json");
        // return r.ReadToEnd();
        
        if (playerMatchStats != null)
            return playerMatchStats;
        
        // string json = ReadJsonFile("games");
        List<PlayerMatchData> list = new List<PlayerMatchData>(4096);

        StringBuilder sb = new();
        while (!r.EndOfStream && list.Count<matchDataLimit)
        {
            int c = r.Read();
            switch (c)
            {
                
                case -1:
                    break;
                case '{':
                    sb.Clear().Append('{');
                    break;
                default:
                    sb.Append((char)c);
                    break;
                case '}':
                    sb.Append('}');
                    string s = sb.ToString();
                    list.Add(JsonConvert.DeserializeObject<PlayerMatchData>(sb.ToString()));
                    break;
            }
        }
        
        playerMatchStats = list;
        return playerMatchStats;
    }

    public static void FreeMemoryHog() => playerMatchStats = null;
}