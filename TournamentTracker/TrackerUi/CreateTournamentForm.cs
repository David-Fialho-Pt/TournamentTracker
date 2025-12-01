using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TournamentTracker;
using TrackerLibrary.Models;
using TrackerLibrary;

namespace TrackerrUi
{
    public partial class CreateTournamentForm : Form
    {
        List<TeamModel> availableTeams = GlobalConfig.Connection.GetTeam_All();
        List<TeamModel> selectedTeams = new List<TeamModel>();
        List<PrizeModel> selectedPrizes = new List<PrizeModel>();

        public CreateTournamentForm()
        {
            InitializeComponent();
            WireUpLists();
        }

        private void WireUpLists()
        {
            selectTeamDropdown.DataSource = null;
            selectTeamDropdown.DataSource = availableTeams;

            selectTeamDropdown.DisplayMember = "TeamName";

            tournamentteamslistbox.DataSource = null;
            tournamentteamslistbox.DataSource = selectedTeams;
            tournamentteamslistbox.DisplayMember = "TeamName";

            prizeslistbox.DataSource = null;
            prizeslistbox.DataSource = selectedPrizes;
            prizeslistbox.DisplayMember = "PlaceName";

        }

        private void addteambutton_Click(object sender, EventArgs e)
        {
           
          TeamModel t = (TeamModel)selectTeamDropdown.SelectedItem; 
           if (t != null)
            {
                availableTeams.Remove(t);
                selectedTeams.Add(t);
                WireUpLists();
                
            }
        }
    }
}
