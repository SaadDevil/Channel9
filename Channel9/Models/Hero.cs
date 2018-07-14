using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Channel9.Models
{
    public class Hero
    {
        public int ID { get; set; }
        [Display(Name = "Hero")]
        public string HeroName { get; set; }
        public Category CategoryID { get; set; }
    }
}