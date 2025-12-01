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
using TrackerLibrary.DataAcess;
using TrackerLibrary.Models;

namespace TrackerrUi
{
    public partial class CreatePrizeForm : Form
    {
        IPrizeRequester callingform;
        public CreatePrizeForm(IPrizeRequester caller)
        {
            InitializeComponent();
            callingform = caller;
        }

        private void createprizebtn_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PrizeModel model = new PrizeModel(placenumberlbl.Text,
                                                  placenamelbl.Text,
                                                  placeamountlbl.Text,
                                                  prizepercentlbl.Text);
               GlobalConfig.Connection.CreatePrize(model);
               callingform.PrizeComplete(model);
                this.Close();
                // placenumberlbl.Text = "";
                // placenamelbl.Text = "";
                // placeamountlbl.Text = "0";
                // prizepercentlbl.Text = "0";

            }
            else
            {
                MessageBox.Show("This form has invalid information. Please check it and try again");
            }
           

        }
        private bool ValidateForm()
        {
            bool output = true;
            int placenumber = 0;
            bool placeNumberValidNumber = int.TryParse(placenumberlbl.Text, out placenumber);

            if (placeNumberValidNumber == false)
            {
                output = false;
            }
            
            if (placenumber < 1)
            {
                output = false; 
            }

            if (placenamelbl.Text.Length == 0)
            {
                output = false;
            }
            decimal prizeamount = 0;
            double prizepercentage = 0;

            bool prizeamountvalid = decimal.TryParse(placeamountlbl.Text, out prizeamount);
            bool prizePercentagevalid = double.TryParse(prizepercentlbl.Text, out prizepercentage);

            if (prizeamountvalid == false || prizePercentagevalid == false)
            {
                output = false;
            }

            if (prizeamount <= 0 && prizepercentage <= 0)
            {
                output = false;
            }

            if (prizepercentage < 0 || prizepercentage > 100)
            {
                output = false;
            }

            return output;

        }
    }
}
