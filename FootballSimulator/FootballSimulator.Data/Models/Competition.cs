using System;
using System.Collections.Generic;
using System.Text;

namespace FootballSimulator.Data.Models
{
    public class Competition
    {
        public string Name { get; set; }

        public Club CurrentHolder { get; set; }

        public ICollection<Club> Clubs { get; set; }
    }
}
