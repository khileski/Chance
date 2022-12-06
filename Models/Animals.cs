using System;
using System.Collections.Generic;

namespace Final.Models
{
    public class Animal
    {
        public int AnimalId {get;set;}
        public string AnimalName {get;set;} = string.Empty;
        public double Weight{get;set;}
        public string Description {get;set;} = string.Empty;
        public string Type {get;set;} = string.Empty;

        public int ShelterId{get;set;}
        public Shelter Shelter {get;set;} = null!;

    }
}