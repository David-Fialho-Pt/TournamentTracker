using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentTracker
{
    public class PrizeModel
    {
        public int Id { get; set; }
        public int PlaceNumber { get; set; }
        public string PlaceName { get; set; }
        public decimal PrizeAmount { get; set; }

        public double PrizePercentage { get; set; }

        public PrizeModel()
        { 
                    
        }
        public PrizeModel(string placenumber, string placename, string prizeamount, string prizepercentage)
        {
            PlaceName = placename;
            int placeNumberValue = 0;
            int.TryParse(placenumber, out placeNumberValue);
            PlaceNumber = placeNumberValue;
            decimal prizeAmountValue = 0;
            decimal.TryParse(prizeamount, out prizeAmountValue);
            PrizeAmount = prizeAmountValue;
            double prizePercentageValue = 0;
            double.TryParse(prizepercentage, out prizePercentageValue);
            PrizePercentage = prizePercentageValue;
        } 

    }
}
