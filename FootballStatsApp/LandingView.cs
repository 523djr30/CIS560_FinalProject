using System.Media;
using Backend;

namespace FootballStatsApp
{
    public partial class LandingView : Form
    {
        /// <summary>
        /// Represents home view.
        /// </summary>
        private LandingTextControl UxLandingTextControl = new();
        /// <summary>
        /// Represents standings view.
        /// </summary>
        private BothDivStandControl UxBothDivStandControl = new();
        /// <summary>
        /// Represents player view.
        /// </summary>
        private PlayerViewControl UxPlayerViewControl = new();
        private PlayerAddControl UxPlayerAddControl = new();
        private PlayerTeamJoinControl UxPlayerTeamJoinControl = new();
        private MatchesViewControl UxMatchesBetweenTeamsControl = new();
        private AddMatchControl UxAddMatchControl = new();
        
        /// <summary>
        /// Represents team view.
        /// </summary>
        private TeamViewControl UxTeamViewControl = new();

        public LandingView()
        {
            InitializeComponent();
            OpenHome();
        }

        /// <summary>
        /// Instantiates Home View.
        /// </summary>
        public void OpenHome()
        {
            UxLandingFlowLayoutPanel.Controls.Clear();
            UxLandingFlowLayoutPanel.Controls.Add(UxLandingTextControl);
        }
        /// <summary>
        /// Instatntiates Player View
        /// </summary>
        public void OpenBothDivsView()
        {
            UxLandingFlowLayoutPanel.Controls.Clear();
            UxLandingFlowLayoutPanel.Controls.Add(UxBothDivStandControl);
        }
        /// <summary>
        /// Instantiaties Player View.
        /// </summary>
        private void OpenPlayerView()
        {
            UxLandingFlowLayoutPanel.Controls.Clear();
            UxLandingFlowLayoutPanel.Controls.Add(UxPlayerViewControl);
        }
        
        private void OpenPlayerAddView()
        {
            UxLandingFlowLayoutPanel.Controls.Clear();
            UxLandingFlowLayoutPanel.Controls.Add(UxPlayerAddControl);
        }

        /// <summary>
        /// Instantiaties Player View.
        /// </summary>
        private void OpenTeamView()
        {
            UxLandingFlowLayoutPanel.Controls.Clear();
            UxLandingFlowLayoutPanel.Controls.Add(UxTeamViewControl);
        }
        
        private void OpenPlayerTeamJoinControl()
        {
            UxLandingFlowLayoutPanel.Controls.Clear();
            UxLandingFlowLayoutPanel.Controls.Add(UxPlayerTeamJoinControl);
        }
        
        private void OpenMatchesBetweenTeamsControl()
        {
            UxLandingFlowLayoutPanel.Controls.Clear();
            UxLandingFlowLayoutPanel.Controls.Add(UxMatchesBetweenTeamsControl);
        }
        
        private void OpenAddMatchControl()
        {
            UxLandingFlowLayoutPanel.Controls.Clear();
            UxLandingFlowLayoutPanel.Controls.Add(UxAddMatchControl);
        }

        /// <summary>
        /// Handles when user clicks "Standings".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void standingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenBothDivsView();
        }

        /// <summary>
        /// Handles the load event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LandingView_Load(Object sender, EventArgs e)
        {
            // DatabaseManage.SetupDB();
        }

        /// <summary>
        /// Handles when user clicks "Home".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenHome();
        }

        /// <summary>
        /// Handles when user clicks "Players".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void playersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenPlayerView();
        }

        private void teamsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenTeamView();
        }

        private void addPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenPlayerAddView();
        }

        private void joinTeamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenPlayerTeamJoinControl();
        }

        private void mathcesBetweenTeamsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenMatchesBetweenTeamsControl();
        }

        private void addMatchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenAddMatchControl();
        }
    }
}
