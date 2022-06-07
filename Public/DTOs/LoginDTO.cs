using System.ComponentModel.DataAnnotations;

namespace Public.DTOs
{
    public class LoginDTO
    {
        public LoginDTO()
        {

        }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string PassWord { get; set; }
    }
}
