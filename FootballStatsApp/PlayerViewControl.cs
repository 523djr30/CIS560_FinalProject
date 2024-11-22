using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Backend;

namespace FootballStatsApp
{
    public partial class PlayerViewControl : UserControl
    {
        public PlayerViewControl()
        {
            InitializeComponent();
            UxSearchTb.Text = "Giovani Bernard";

        }

        public static string Sanitize(string s)
        {
            return s.Replace('\'', ' ').Replace('\"', ' ');
        }

        private void UxSearchBtn_Click(object sender, EventArgs e)
        {
            string name = UxSearchTb.Text;
            string FirstName,LastName;

            int split = name.IndexOf(' ');
            if (split == -1)
            {
                FirstName = name.Trim();
                LastName = "";
            }
            else
            {
                FirstName = Sanitize(name.Substring(0, split));
                LastName = Sanitize(name.Substring(1 + split));
            }

            UxPlayersListBox.Items.Clear();
            Table? t = Backend.DatabaseManage.QueryFileText("Declare @FirstName NVarChar(32) = N'"+FirstName+"';\n"+
                                                           "Declare @LastName NVarChar(32) = N'"+LastName+"';",
                "CareerStatistics");
            Table? t2 = Backend.DatabaseManage.QueryText("Select p.PlayerId, p.Bio from Football.Player p where p.FirstName=N'"+FirstName+"' and p.LastName=N'"+LastName+'\'');
            if (t != null)
            {
                if (t2.Data.Length != 0)
                {
                    int id = t2[0].Int["PlayerId"];
                    UxPlayersListBox.Items.Add("Player Found with ID "+id);
                    string? bio = t2[0].Str["Bio"];
                    if(bio!=null)
                        UxPlayersListBox.Items.Add(bio);


                    Table? t3 = Backend.DatabaseManage.QueryText("Select ptm.StartDate,ptm.EndDate,t.Name from Football.PlayerTeamHistory ptm "+
                                                                 "Inner join Football.Team t on t.TeamId = ptm.TeamId \r\n"+
                                                                 " where ptm.PlayerID="+id);
                    foreach (Row r in t3)
                    {
                        DateTimeOffset endDate = r.Date["EndDate"];
                        DateTimeOffset startDate = r.Date["StartDate"];
                        string endDateStr;

                        if (endDate.Equals(default))
                            endDateStr = "Present";
                        else
                            endDateStr =endDate.Date.ToShortDateString();
                        
                        UxPlayersListBox.Items.Add("Member of "+r.Str["Name"]+" from "+startDate.Date.ToShortDateString()+" to " +endDateStr);
                    }
                    UxPlayersListBox.Items.Add(t.GetHeaderText());
                }
                else
                {
                    UxPlayersListBox.Items.Add("Player Not Found");
                }
                

                DatabaseManage.PrintTable(t);


                UxPlayersListBox.Items.Add(t.ToString());

            }
        }

        private void UxPlayersListBox_DataContextChanged(object sender, EventArgs e)
        {

        }

        private void UxSearchTb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
