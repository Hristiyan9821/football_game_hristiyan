using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Hristiyan_60
{
    public class Team
    {
        public string Name { get; set; }
        public Coach Coach { get; set; }
        public List<FootballPlayer> Players { get; set; }

        public Team()
        {
            Players = new List<FootballPlayer>();
        }
    }
}