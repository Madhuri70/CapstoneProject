using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Blog_Tracker.Models
{
    public class EmpInfo
    {
        [Key]
        public string EmailId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int PassCode { get; set; }
        [Required]
        [DataType(DataType.Date)]

        public DateTime DateOfJoining { get; set; }
    }
}