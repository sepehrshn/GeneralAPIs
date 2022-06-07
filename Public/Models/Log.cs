using System;
using System.ComponentModel.DataAnnotations;

namespace Public.Models
{
    public class Log
    {
        public Log()
        {
            LogDate= DateTime.Now;
        }
        public int LogID { get; set; }
        [Required]
        public string Path { get; set; }
        public DateTime LogDate { get; set; } 
    }
}
