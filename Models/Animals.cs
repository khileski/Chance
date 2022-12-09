using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Final.Models
{
    public class Animal
    {
        public int AnimalId {get;set;}
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string AnimalName {get;set;} = string.Empty;
        [Range(0,999.9)]
        [Required]
        public double Weight{get;set;}
        [StringLength(200, MinimumLength = 3)]
        [Required]
        public string Description {get;set;} = string.Empty;
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Type {get;set;} = string.Empty;

        public int ShelterId{get;set;}//foriegn key
        public Shelter? Shelter {get;set;} = null!;//Navigation Property "?" makes it optional

    }
}