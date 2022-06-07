using System;
using System.ComponentModel.DataAnnotations;

namespace Public.Models
{
    public class WebsiteRequest
    {
        public WebsiteRequest()
        {
            RequestDate = DateTime.Now;
            IsDone = false;
            IsSeen = false;
        }
        public int RequestID { get; set; }
        [Required]
        public string Subject { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string FullName { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        public string Email { get; set; }   
        public DateTime RequestDate { get; set; }
        public bool IsSeen { get; set; }
        public bool IsDone { get; set; }
    }
}
