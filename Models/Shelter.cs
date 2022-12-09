using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Final.Models
{
    public class Shelter
    {
        public int ShelterId {get;set;}

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Name {get;set;} = string.Empty;
        [StringLength(100,MinimumLength =  4)]
        [Required]
        public string Address {get;set;} = string.Empty;
        [StringLength (60, MinimumLength =3)]
        [Required]
        public string Town {get;set;} = string.Empty; 

        public List<Animal> Animals {get;set;} = new List<Animal>();//Navigation property
    }
}