using System.ComponentModel.DataAnnotations;

namespace BlockLib
{
    public class AdminInfo
    {
      
        
            [Key]
            public string EmailId { get; set; }
            [Required]
            public string Password { get; set; }

        }
    }

