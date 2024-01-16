using System.Collections.Generic;

namespace Orkesterapp.Classes
{
    public class Orchester
    {
        public int id { get; set; }
        public string orchestraName { get; set; }

        public List<User> users { get; set; }
        public List<Performance> performances { get; set; }
    }
}