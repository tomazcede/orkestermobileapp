using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orkesterapp.Classes
{
    public class Venue
    {
        public int id { get; set; }
        public string venueName { get; set; }
        public string location { get; set; }


        public List<Performance> performances { get; set; }
    }
}