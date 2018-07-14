using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Channel9.Models
{
    public class Sports
    {
        public int ID { get; set; }
        [Display(Name = "Name")]
        public string SportsName { get; set; }
        [DataType(DataType.Time)]
        [DisplayFormat(ApplyFormatInEditMode =true, DataFormatString=@"{0:hh\:mm}")]
        public DateTime Time { get; set; }
    }
}