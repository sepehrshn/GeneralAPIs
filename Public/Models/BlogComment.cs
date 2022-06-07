using System;
using System.ComponentModel.DataAnnotations;

namespace Public.Models
{
    public class BlogComment
    {
        public BlogComment()
        {
            IsActive= true;
            CommentDate = DateTime.Now;
        }
        public int BlogID { get; set; }
        public int UserID { get; set; }
        [Required]
        public string Description { get; set; }
        public DateTime CommentDate { get; set; }
        public bool IsActive { get; set; }     
        public int Parent { get; set; }   
    }
}
