using System;
using System.ComponentModel.DataAnnotations;

namespace Public.Models
{
    public class WebsiteText
    {
        public WebsiteText()
        {

        }
        public int TextID { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public int SectionID { get; set; }
        public int AutherID { get; set; }   
    }
}
