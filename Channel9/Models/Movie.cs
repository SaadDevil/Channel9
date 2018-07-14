using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Channel9.Models
{
    public class Movie
    {
        public int ID { get; set; }
        [Display(Name = "Movie")]
        public string MovieNAme { get; set; }
        [Display(Name = "Producer")]
        public string MovieProducer { get; set; }
        [Display(Name = "Director")]
        public string MovieDirector { get; set; }
        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:d}")]
        public DateTime ReleaseDate { get; set; }
        public int GenreID { get; set; }
        public int CategoryID { get; set; }
        public int HeroID { get; set; }
        public Genre Genre { get; set; }
        public Category Category { get; set; }
        public Hero Hero { get; set; }
    }
}