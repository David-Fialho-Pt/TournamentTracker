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
    public partial class CreateTournamentForm : Form, IPrizeRequester, ITeamRequester
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

        private void createprizebutton_Click(object sender, EventArgs e)
        {
            CreatePrizeForm frm = new CreatePrizeForm(this);
            frm.Show();

        }

        public void PrizeComplete(PrizeModel model)
        {

            selectedPrizes.Add(model);
            WireUpLists();
        }

        public void TeamComplete(TeamModel model)
        {
            selectedTeams.Add(model);
            WireUpLists();

        }

        private void createnewteamlink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateTeamForm frm = new CreateTeamForm(this);
            frm.Show();
        }

        private void removeSelectedTeams_Click(object sender, EventArgs e)
        {
            TeamModel t = (TeamModel)tournamentteamslistbox.SelectedItem;
            if (t != null)
            {
                selectedTeams.Remove(t);
                availableTeams.Add(t);
                WireUpLists();
            }
        }

        private void RemoveSelectedPrize_Click(object sender, EventArgs e)
        {
            PrizeModel p = (PrizeModel)prizeslistbox.SelectedItem;
            if (p != null)
            {
                selectedPrizes.Remove(p);
                WireUpLists();
            }
        }

        private void createtournamentbutton_Click(object sender, EventArgs e)
        {
            decimal fee = 0;
            bool feeAcceptable = decimal.TryParse(entryfee.Text, out fee);
            if (!feeAcceptable)
            {
                MessageBox.Show("You need to enter a valid Entry Fee.", "Invalid Fee",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            TournamentModel tm = new TournamentModel();
            tm.TournamentName = tournamentnamevalue.Text;
            tm.EntryFee = fee;
            tm.Prizes = selectedPrizes;
            tm.EnteredTeams = selectedTeams;
            TournamentLogic.CreateRounds(tm);
            GlobalConfig.Connection.CreateTournament(tm);


        }
    }
}
