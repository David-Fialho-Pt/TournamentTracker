using System.ComponentModel;
using TrackerLibrary.Models;

namespace TrackerUi
{
    public partial class TournamentViewerForm : Form
    {
        private TournamentModel tournament;
        BindingList<int> rounds = new BindingList<int>();
        BindingList<MatchupModel> selectedMatchups = new BindingList<MatchupModel>();

       

        public TournamentViewerForm(TournamentModel tournamentModel)
        {
            InitializeComponent();

            tournament = tournamentModel;
            WireUpLists();
     
            LoadFormData();
            LoadRounds();
        }

        private void LoadFormData()
        {
            Tournamentnamelabel.Text = tournament.TournamentName;
        }

        private void WireUpLists()
        {
            
           rounddropdown.DataSource = rounds;
            matchuplistbox.DataSource = selectedMatchups;
            matchuplistbox.DisplayMember = "DisplayName";



        }
      

        private void LoadRounds()
        {
            

            rounds.Clear();
            rounds.Add(1);
            int currRound = 1;

            foreach (List<MatchupModel> matchups in tournament.Rounds)
            {
                if (matchups.First().MatchupRound > currRound)
                {
                    currRound = matchups.First().MatchupRound;
                    rounds.Add(currRound);
                }
            }
            //roundsBinding.ResetBindings(false);
            LoadMatchups(1);
        }

        private void rounddropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMatchups((int)rounddropdown.SelectedItem);
        }

        private void LoadMatchups(int round)
        {
            
            foreach (List<MatchupModel> matchups in tournament.Rounds)
            {
                if (matchups.First().MatchupRound == round)
                {
                    selectedMatchups.Clear();
                    foreach (MatchupModel m in matchups)
                    {
                        selectedMatchups.Add(m);
                    }
                    
                }
            }
            //matchupsBinding.ResetBindings(false);
            LoadMatchup(selectedMatchups.First());

        }
        private void LoadMatchup(MatchupModel m)
        {
            if

            for (int i = 0; i < m.Entries.Count; i++)
            {
                if (i == 0)
                {
                    if (m.Entries[0].TeamCompeting != null)
                    {
                        team1label.Text = m.Entries[0].TeamCompeting.TeamName;
                        teamonescoretb.Text = m.Entries[0].Score.ToString();

                        teamtwolabel.Text = "<bye>";
                        teamtwoscoretb.Text = "0";
                    }
                    else
                    {
                        team1label.Text = "Not Yet Set";
                        teamonescoretb.Text = "";
                    }
                }
                if (i == 1)
                {
                    if (m.Entries[1].TeamCompeting != null)
                    {
                        teamtwolabel.Text = m.Entries[1].TeamCompeting.TeamName;
                        teamtwoscoretb.Text = m.Entries[1].Score.ToString();
                    }
                    else
                    {
                        teamtwolabel.Text = "Not Yet Set";
                        teamtwoscoretb.Text = "";
                    }
                }
            }

        }

        private void matchuplistbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMatchup((MatchupModel)matchuplistbox.SelectedItem);

        }
    }
}
