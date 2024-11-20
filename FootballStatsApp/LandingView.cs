using System.Media;

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
    }
}
