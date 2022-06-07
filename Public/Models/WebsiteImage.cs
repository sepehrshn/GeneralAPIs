using System;
using System.ComponentModel.DataAnnotations;

namespace Public.Models
{
    public class WebsiteImage
    {
        public WebsiteImage()
        {

        }
        public int ImgID { get; set; }
        public int SectionID { get; set; }
        [Required]
        public string ImgPath { get; set; }
        public string Alt { get; set; }   
    }
}
