using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orkesterapp.Classes
{
    public class Performance
    {
        public int id { get; set; }
        public DateTime date { get; set; }


        public int orchesterID { get; set; }
        public Orchester orchester { get; set; }

        public int venueID { get; set; }
        public Venue venue { get; set; }
    }
}