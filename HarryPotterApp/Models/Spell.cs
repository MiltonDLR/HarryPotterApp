using System;
using System.Collections.Generic;
using System.Text;

namespace HarryPotterApp.Models
{
    public class Spell
    {
        public string _id { get; set; }
        public string spell { get; set; }
        public string type { get; set; }
        public string effect { get; set; }
    }
    public class SpellRoot
    {
        public List<Spell> Lista { get; set; }

    }
}
