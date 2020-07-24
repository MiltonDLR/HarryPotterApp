using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace HarryPotterApp.Models
{
    public class Character
    {
        public string _id { get; set; }
        public string name { get; set; }
        public string alias { get; set; }
        public string patronus { get; set; }
        public string wand { get; set; }
        public string boggart { get; set; }
        public string role { get; set; }
        public string house { get; set; }
        public string school { get; set; }
        public int __v { get; set; }
        public bool ministryOfMagic { get; set; }
        public bool orderOfThePhoenix { get; set; }
        public bool dumbledoresArmy { get; set; }
        public bool deathEater { get; set; }
        public string bloodStatus { get; set; }
        public string species { get; set; }

    }
    public class CharacterRoot
    {
        public List<Character> Lista { get; set; }

    }
}
