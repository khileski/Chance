using System;
using System.Collections.Generic;

namespace Final.Models
{
    public class Shelter
    {
        public int ShelterId {get;set;}
        public string Name {get;set;} = string.Empty;
        public string Address {get;set;} = string.Empty;
        public string Town {get;set;} = string.Empty; 

        public List<Animal> Animals {get;set;} = new List<Animal>();
    }
}