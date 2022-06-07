using System;
using System.ComponentModel.DataAnnotations;

namespace Public.Models
{
    public class Brand
    {
        public Brand()
        {
            IsActive= true;
        }
        public int BrandID { get; set; }
        [Required]
        public string Caption { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Logo { get; set; }
        public string Img { get; set; }
        public string Floor { get; set; }     
        public bool IsActive { get; set; }   
    }
}
