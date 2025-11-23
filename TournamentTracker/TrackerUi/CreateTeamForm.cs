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
        public CreateTeamForm()
        {
            InitializeComponent();
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
                GlobalConfig.Connection.CreatePerson(p);
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
    }
}
