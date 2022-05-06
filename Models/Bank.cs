using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyDBProject.Models
{
    public class Bank
    {
        [Key]
        public int Bank_id { get; set; }
        public string Bank_name { get; set; }
        public string Branch_name { get; set; }
        public string Bank_IFSC { get; set; }
    }
}
