using Microsoft.SqlServer.Management.HadrModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Backend;

namespace FootballStatsApp
{
    /// <summary>
    /// Representing the information needed for team cards to be displayed.
    /// </summary>
    public class TeamCardModel
    {
        public string stadium = "none";
        public string city = "none";
        public string startDate = "none";
        public string divisionName = "none";
        public int numWins = 0;
        public int numLoss = 0;

        public Table? roster;
        public Table? matches;
    }
}
