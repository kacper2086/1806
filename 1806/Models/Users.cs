using System.ComponentModel.DataAnnotations;

namespace YourNamespace.Models
{
    public class Users
    {
        public int id { get; set; }

        [Required(ErrorMessage = "Username is required")]
        public string username { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string password { get; set; }

        [Required(ErrorMessage = "Role is required")]
        public string role { get; set; }
    }
}
