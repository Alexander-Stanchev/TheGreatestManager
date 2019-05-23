using System;
using System.Collections.Generic;
using System.Text;

namespace FootballSimulator.Data.Models
{
    public class Club
    {
        public string Name { get; set; }

        public DateTime Founded { get; set; }

        public Coach Coach { get; set; }

        public ICollection<Player> Players { get; set; }
    }
}
