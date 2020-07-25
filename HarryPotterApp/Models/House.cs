using System;
using System.Collections.Generic;
using System.Text;

namespace HarryPotterApp.Models
{
    public class House
    {
        public string _id { get; set; }
        public string name { get; set; }
        public string mascot { get; set; }
        public string headOfHouse { get; set; }
        public string houseGhost { get; set; }
        public string founder { get; set; }
        public int __v { get; set; }
        public string school { get; set; }
        public IList<string> members { get; set; }
        public IList<string> values { get; set; }
        public IList<string> colors { get; set; }
    }

    public class HouseRoot
    {
        public IList<House> Lista { get; set; }

    }
}
