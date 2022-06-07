using System;
using System.ComponentModel.DataAnnotations;

namespace Public.Models
{
    public class WebsiteSection
    {
        public WebsiteSection()
        {

        }
        public int SectionID { get; set; }
        public string Caption { get; set; }  
    }
}
