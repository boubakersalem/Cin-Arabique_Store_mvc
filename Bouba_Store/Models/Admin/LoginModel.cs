using System.ComponentModel.DataAnnotations;

namespace Bouba_Store.Models.Admin
{
    public class LoginModel

    {
        [Required]
        public string? Username { get; set; }

        [Required]
        public string? Password { get; set; }
    }
}
