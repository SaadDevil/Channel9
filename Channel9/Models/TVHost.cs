using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Channel9.Models
{
    public class TVHost
    {
        public int ID { get; set; }
       
        public string HostName { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
      
    }
}