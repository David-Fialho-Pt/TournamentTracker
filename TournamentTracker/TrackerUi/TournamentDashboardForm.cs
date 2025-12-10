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
using TrackerUi;

namespace TrackerrUi
{
    public partial class TournamentDashboardForm : Form
    {
        List<TournamentModel> tournaments = GlobalConfig.Connection.GetTournament_All();
        public TournamentDashboardForm()
        {
            InitializeComponent();
            WireUpLists();
        }
        private void WireUpLists()
        {
            loadexistingtounamentsdropdown.DataSource = tournaments;

            loadexistingtounamentsdropdown.DisplayMember = "TournamentName";
        }

        private void createtournamentbtn_Click(object sender, EventArgs e)
        {
            CreateTournamentForm frm = new CreateTournamentForm();
            frm.Show();
        }

        private void loadtournamentbtn_Click(object sender, EventArgs e)
        {
            TournamentModel tm = (TournamentModel)loadexistingtounamentsdropdown.SelectedItem;
            TournamentViewerForm frm = new TournamentViewerForm(tm);
            frm.Show();
        }
    }
}
