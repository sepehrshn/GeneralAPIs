using System;
using System.ComponentModel.DataAnnotations;

namespace Public.Models
{
    public class Restaurant
    {
        public Restaurant()
        {
            IsActive= true;
        }
        public int RestaurantID { get; set; }
        [Required]
        public string Caption { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Logo { get; set; }
        public Type Type { get; set; }
        public DateTime StartDate { get; set; }   
        public bool IsOpen { get; set; }   
        public bool IsActive { get; set; }   
    }
    public  enum Type
    {
        Iranian,Foreign
    }
}
