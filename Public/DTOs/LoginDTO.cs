using System.ComponentModel.DataAnnotations;

namespace Public.DTOs
{
    public class LoginDTO
    {
        public LoginDTO()
        {

        }
        [Required, MaxLength(11),MinLength(11)]
        public string PhonNumber { get; set; }
        public string PassWord { get; set; }
    }
}
