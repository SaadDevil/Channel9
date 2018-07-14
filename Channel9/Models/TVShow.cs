using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Channel9.Models
{
    public class TVShow
    {
        public int ID { get; set; }
        [Display(Name ="Show Name")]
        public string ShowName { get; set; }
        [DataType(DataType.Time)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = @"{0:hh\:mm}")]
        [Display(Name = "Show Time")]
        public DateTime ShowTime { get; set; }

        [Display(Name ="Host")]
        public int TVHostID { get; set; }
       
        public TVHost TVHost{ get; set; }
       
    }
}