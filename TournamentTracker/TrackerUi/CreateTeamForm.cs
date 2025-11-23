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

namespace TrackerrUi
{
    public partial class CreateTeamForm : Form
    {
        private List<PersonModel> availableTeamMembers = GlobalConfig.Connection.GetPerson_All();
        private List<PersonModel> selectedTeamMembers = new List<PersonModel>();
        public CreateTeamForm()
        {
            InitializeComponent();
            //CreateSampleData();
            wireUpLists();
        }

        private void CreateSampleData()
        {

            availableTeamMembers.Add(new PersonModel { FirstName = "Tim", LastName = "Corey" });
            availableTeamMembers.Add(new PersonModel { FirstName = "Sue", LastName = "Storm" });
            selectedTeamMembers.Add(new PersonModel { FirstName = "Jane", LastName = "Smith" });
            selectedTeamMembers.Add(new PersonModel { FirstName = "Bill", LastName = "Jones" });

        }
        private void wireUpLists()
        {
            selectteammemberdropdown.DataSource = null;
            selectteammemberdropdown.DataSource = availableTeamMembers;
            selectteammemberdropdown.DisplayMember = "FullName";
            teammemberslistbox.DataSource = null;
            teammemberslistbox.DataSource = selectedTeamMembers;
            teammemberslistbox.DisplayMember = "FullName";
        }
        private void creatememberbtn_Click(object sender, EventArgs e)
        {
            if (validateForm())
            {
                PersonModel p = new PersonModel();
                p.FirstName = firstnamevalue.Text;
                p.LastName = lastnamevalue.Text;
                p.EmailAddress = emailvalue.Text;
                p.CellPhoneNumber = cellphonevalue.Text;
                p = GlobalConfig.Connection.CreatePerson(p);
                selectedTeamMembers.Add(p);
                wireUpLists();

                firstnamevalue.Text = "";
                lastnamevalue.Text = "";
                emailvalue.Text = "";
                cellphonevalue.Text = "";


            }
            else
            {
                MessageBox.Show("You need to fill in all of the fields.");
            }

        }
        private bool validateForm()
        {

            if (firstnamevalue.Text.Length == 0)
            {
                return false;
            }
            if (lastnamevalue.Text.Length == 0)
            {
                return false;
            }
            if (emailvalue.Text.Length == 0)
            {
                return false;
            }
            if (cellphonevalue.Text.Length == 0)
            {
                return false;
            }
            return true;
        }

        private void addmemberbutton_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)selectteammemberdropdown.SelectedItem;
            if (p != null)
            {
                availableTeamMembers.Remove(p);
                selectedTeamMembers.Add(p);
                wireUpLists();
            }
        }

        private void deleteselectedmemberbtn_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)teammemberslistbox.SelectedItem;
            if (p != null)
            {
                selectedTeamMembers.Remove(p);
                availableTeamMembers.Add(p);
                wireUpLists();

            }
        }

        private void createteambtn_Click(object sender, EventArgs e)
        {
            TeamModel t = new TeamModel();
            t.TeamName = teamnamevalue .Text;
            t.TeamMembers = selectedTeamMembers;

            GlobalConfig.Connection.CreateTeam(t);  

        }
    }
}
