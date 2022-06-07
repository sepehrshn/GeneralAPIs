using System;
using System.ComponentModel.DataAnnotations;

namespace Public.Models
{
    public class Service
    {
        public Service()
        {
            IsActive= true;
        }
        public int ServiceID { get; set; }
        [Required]
        public string Caption { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Logo { get; set; }
        public bool IsActive { get; set; }   
    }
}
