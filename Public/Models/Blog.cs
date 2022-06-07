using System;
using System.ComponentModel.DataAnnotations;

namespace Public.Models
{
    public class Blog
    {
        public Blog()
        {
            IsActive= true;
            PublishDate = DateTime.Now;
        }
        public int BlogID { get; set; }
        [Required]
        public string Caption { get; set; }
        [Required]
        public string Description { get; set; }
        public DateTime PublishDate { get; set; }
        public bool IsActive { get; set; }     
        public int AutherID { get; set; }   
    }
}
