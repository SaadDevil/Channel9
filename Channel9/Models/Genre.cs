using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Channel9.Models
{
    public class Genre
    {
        public int ID { get; set; }
        [Display(Name = "Genre")]
        public string GenreName { get; set; }
    }
}