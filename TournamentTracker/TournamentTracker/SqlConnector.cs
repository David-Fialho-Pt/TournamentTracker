using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentTracker
{
    public class SqlConnector : IDataConnection
    {
        /// TODO - Make the CreatePrize method actually save to the database
        /// <summary>
        /// Saves a new prizae to the database
        /// </summary>
        /// <param name="model"></param>
        /// <returns>the prize information, including id</returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {
            model.Id = 1;
            return model;
        }


    }
}
