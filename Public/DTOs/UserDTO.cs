using Public.Models;

namespace Public.DTOs
{
    public class UserDTO
    {
        public UserDTO()
        {

        }
        public int UserID { get; set; }
        public string FullName { get; set; }
        public Roles Role { get; set; }
    }
}
