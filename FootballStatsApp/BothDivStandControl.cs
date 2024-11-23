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
            PopulateData();
        }
        
        private void PopulateWithListAfc(List<Row> list, string divisionName)
        {
            // Create all team cards
            List<Control> controls = new();
            foreach(Row row in list)
            {
                controls.Add(
                    new TeamInDiv(
                        row.GetItem<string>("TeamName"),
                        Convert.ToInt32(row.GetItem<Int64>("TeamRank")),
                        row.GetItem<int>("Wins"),
                        row.GetItem<int>("Losses")
                        )
                    );
            }
            // Place them into the corresponding division panel
            Control singleDiv = new SingleDivControl(divisionName, controls);
            // Place that divpanel into the main panel
            UxAFCFlowPanel.Controls.Add(singleDiv);
        }
        private void PopulateWithListNfc(List<Row> list, string divisionName)
        {
            // Create all team cards
            List<Control> controls = new();
            foreach (Row row in list)
            {
                controls.Add(
                    new TeamInDiv(
                        row.GetItem<string>("TeamName"),
                        Convert.ToInt32(row.GetItem<Int64>("TeamRank")),
                        row.GetItem<int>("Wins"),
                        row.GetItem<int>("Losses")
                        )
                    );
            }
            // Place them into the corresponding division panel
            Control singleDiv = new SingleDivControl(divisionName, controls);
            // Place that divpanel into the main panel
            UxNFCFlowLayoutPanel.Controls.Add(singleDiv);
        }

        private void PopulateData()
        {
            // Query database
            Table? result = Backend.DatabaseManage.QueryFileText(
                "", 
                "DivisionRanking");
            List<Row> results_Afc = new();
            List<Row> results_Nfc = new();

            foreach (Row row in result)
            {
                if(row.GetItem<string>("DivisionName").Contains("AFC")){
                    results_Afc.Add(row);
                }
                else if (row.GetItem<string>("DivisionName").Contains("NFC"))
                {
                    results_Nfc.Add(row);
                }
            }
            List<Row> results_Afc_East = new();
            List<Row> results_Afc_North = new();
            List<Row> results_Afc_South = new();
            List<Row> results_Afc_West = new();
            foreach(Row row in results_Afc)
            {
                if (row.GetItem<string>("DivisionName").Contains("EAST"))
                {
                    results_Afc_East.Add(row);
                }
                else if (row.GetItem<string>("DivisionName").Contains("WEST"))
                {
                    results_Afc_West.Add(row);
                }
                else if (row.GetItem<string>("DivisionName").Contains("NORTH"))
                {
                    results_Afc_North.Add(row);
                }
                else if (row.GetItem<string>("DivisionName").Contains("SOUTH"))
                {
                    results_Afc_South.Add(row);
                }
            }

            List<Row> results_Nfc_East = new();
            List<Row> results_Nfc_North = new();
            List<Row> results_Nfc_South = new();
            List<Row> results_Nfc_West = new();
            foreach (Row row in results_Nfc)
            {
                if (row.GetItem<string>("DivisionName").Contains("EAST"))
                {
                    results_Nfc_East.Add(row);
                }
                else if (row.GetItem<string>("DivisionName").Contains("WEST"))
                {
                    results_Nfc_West.Add(row);
                }
                else if (row.GetItem<string>("DivisionName").Contains("NORTH"))
                {
                    results_Nfc_North.Add(row);
                }
                else if (row.GetItem<string>("DivisionName").Contains("SOUTH"))
                {
                    results_Nfc_South.Add(row);
                }
            }

            PopulateWithListAfc(results_Afc_North, "AFC NORTH");
            PopulateWithListAfc(results_Afc_South, "AFC SOUTH");
            PopulateWithListAfc(results_Afc_East, "AFC EAST");
            PopulateWithListAfc(results_Afc_West, "AFC WEST");
            PopulateWithListNfc(results_Nfc_North, "NFC NORTH");
            PopulateWithListNfc(results_Nfc_South, "NFC SOUTH");
            PopulateWithListNfc(results_Nfc_East, "NFC EAST");
            PopulateWithListNfc(results_Nfc_West, "NFC WEST");
            Update();
            // Set grids
        }
    }
}
