using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockLib
{
    public class BlogInfo
    {
        [Key]
        public int BlodId { get; set; }
        [Required]
        public string Title { get; set; }

        [Required]
        public string Subject { get; set; }
        [Required]
        public string BlogUrl { get; set; }
        [Required]
        public string EmpEmailId { get; set; }
        [Required]
        public DateTime DateOfCreation { get; set; }
        public int BlogId { get; set; }
    }
}

