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
    public partial class PlayerAddControl : UserControl
    {
        public PlayerAddControl()
        {
            InitializeComponent();
        }

        public static string Sanitize(string s)
        {
            return s.Replace('\'', ' ').Replace('\"', ' ');
        }

        private void UxSearchBtn_Click(object sender, EventArgs e)
        {
            string name = LastNameBox.Text;
            string FirstName,LastName;

            FirstName = FirstNameBox.Text;
            LastName = LastNameBox.Text;
            int PlayerId = 12874689;
            Table? t = DatabaseManage.QueryText("Select Max(p.PlayerId) id from Football.Player p");
            PlayerId = t[0].Int["id"]+1;
            
            DatabaseManage.InsertRows("Player", "PlayerId,FirstName,LastName", [[PlayerId, FirstName, LastName]]);
        }

        private void UxPlayersListBox_DataContextChanged(object sender, EventArgs e)
        {

        }

        private void UxSearchTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
