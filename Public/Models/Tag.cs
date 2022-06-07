using System;
using System.ComponentModel.DataAnnotations;

namespace Public.Models
{
    public class Tag
    {
        public Tag()
        {
        }
        public int BlogID { get; set; }
        [Required]
        public string Caption { get; set; }
    }
}
