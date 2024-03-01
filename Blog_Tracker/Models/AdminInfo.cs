using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Blog_Tracker.Models
{

}
public class AdminInfo
{
    [Key]
    public string EmailId { get; set; }
    [Required]
    public string Password { get; set; }

}