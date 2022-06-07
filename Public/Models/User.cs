using System;
using System.ComponentModel.DataAnnotations;

namespace Public.Models
{
    public class User
    {
        public User()
        {
            UserName = PhoneNumber;
            IsActive= true;
            joiningDate= DateTime.Now;
            Token = Guid.NewGuid().ToString();
        }
        public int UserID { get; set; }
        [Required,MaxLength(11),MinLength(11)]
        public string PhoneNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime joiningDate { get; set; }
        public Roles Role { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public string Token { get; set; }
        public bool IsActive { get; set; }
        
    }

    public enum Roles
    {
       Admin,Customer,Editor
    }
}
