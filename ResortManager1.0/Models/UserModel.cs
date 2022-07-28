using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace Resort_Management.Models
{
    public class UserModel
    {
        [Required]
        public int userId { get; set; }
        [Required]
        public string fullName { get; set; }
        [Key]
        public string Email { get; set; }
        public string Password { get; set; }

        public DateTime CreatedDateTime { get; set; } = DateTime.Now;

    }
}
