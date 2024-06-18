using System.ComponentModel.DataAnnotations;

namespace YourNamespace.Models
{
    public class Users
    {
        public int id { get; set; }
        [Required]
        public string username { get; set; }

        [Required]
        public string password { get; set; }

        [Required]
        public string role { get; set; }
    }
}
