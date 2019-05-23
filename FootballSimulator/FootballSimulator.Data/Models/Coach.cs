using System;
using System.Collections.Generic;
using System.Text;

namespace FootballSimulator.Data.Models
{
    public class Coach
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public Club Club { get; set; }
    }
}
