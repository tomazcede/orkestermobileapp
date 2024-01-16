using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orkesterapp.Classes
{
    public class User
    {
        public int id { get; set; }
        public string lastName { get; set; }
        public string firstMidName { get; set; }
        public string email { get; set; }
        public string geslo { get; set; }


        public int roleID { get; set; }
        public Role role { get; set; }
        public int orchesterID { get; set; }
        public Orchester orchester { get; set; }
    }
}