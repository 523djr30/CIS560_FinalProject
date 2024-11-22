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
    public partial class BothDivStandControl : UserControl
    {
        public BothDivStandControl()
        {
            InitializeComponent();
            PopulateData("2024");
        }
        
        private void PopulateData(string season)
        {
            // Query database
            Table? result = Backend.DatabaseManage.QueryFileText(
                "Declare @SeasonId INT = " + season + ";\n" +
                "Declare @DivisionCode NVARCHAR(32) = N'AFC';\n", 
                "GetDivStats");

            Table? results_Afc;
            Table? results_Nfc;
            // Filter Data
            UxAFCDataGridView.DataContext = result;
            Update();
            // Set grids
        }
    }
}
