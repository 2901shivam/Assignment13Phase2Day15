using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplicationAssignment12Day15.Models
{
    public class Course
    {
        [Key]
        public int CId { get; set; }

        public string CName { get; set; }

        public int CFee { get; set; }

        public string Status { get; set; }

        public string Technology { get; set; }



    }
}