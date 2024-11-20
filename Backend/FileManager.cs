using System;
using System.Collections.Generic;
using System.IO;
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
    }

    private static Dictionary<string, string> TeamAbbreviations = new()
    {
        { "ARZ", "Arizona Cardinals" },
        { "ARI", "Arizona Cardinals" },
        { "ATL", "Atlanta Falcons" },
        { "BLT", "Baltimore Ravens" },
        { "BAL", "Baltimore Ravens" },
        { "BUF", "Buffalo Bills" },
        { "CAR", "Carolina Panthers" },
        { "CHI", "Chicago Bears" },
        { "CIN", "Cincinnati Bengals" },
        { "CLV", "Cleveland Browns" },
        { "CLE", "Cleveland Browns" },
        { "DAL", "Dallas Cowboys" },
        { "DEN", "Denver Broncos" },
        { "DET", "Detroit Lions" },
        { "GB", "Green Bay Packers" },
        { "HST", "Houston Texans" },
        { "HOU", "Houston Texans" },
        { "IND", "Indianapolis Colts" },
        { "JAX", "Jacksonville Jaguars" },
        { "JAC", "Jacksonville Jaguars" },
        { "KC", "Kansas City Chiefs" },
        { "LV", "Las Vegas Raiders" },
        { "LAC", "Los Angeles Chargers" },
        { "LA", "Los Angeles Rams" },
        { "LAR", "Los Angeles Rams" },
        { "MIA", "Miami Dolphins" },
        { "MIN", "Minnesota Vikings" },
        { "NE", "New England Patriots" },
        { "NO", "New Orleans Saints" },
        { "NYG", "New York Giants" },
        { "NYJ", "New York Jets" },
        { "PHI", "Philadelphia Eagles" },
        { "PIT", "Pittsburgh Steelers" },
        { "SF", "San Francisco 49ers" },
        { "SEA", "Seattle Seahawks" },
        { "TB", "Tampa Bay Buccaneers" },
        { "TEN", "Tennessee Titans" },
        { "WAS", "Washington Commanders" }
    };


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
}