using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Channel9.Models
{
    public class Category
    {
        public int ID { get; set; }
        [Display(Name = "Category")]
        public string CategroyName { get; set; }
    }
}