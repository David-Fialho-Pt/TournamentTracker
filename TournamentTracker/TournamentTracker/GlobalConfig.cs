using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentTracker
{
    public static class GlobalConfig
    {
        public static List<IDataConnection> Connections { get; private set; } = new List<IDataConnection>();
        public static void InitializeConnections(bool database, bool textfiles)
        {
            if (database)
            { 
                //TODO - Set up thesql connector properly
                SqlConnector sql = new SqlConnector();
                Connections.Add(sql);
                    
            }
            if (textfiles)
            {
                //TODO - Create the text connection

                TextConnection text = new TextConnection();
                Connections.Add(text);

            }

        }
    }
}
