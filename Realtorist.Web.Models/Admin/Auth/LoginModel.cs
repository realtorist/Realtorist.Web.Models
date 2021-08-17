using System.ComponentModel.DataAnnotations;

namespace Realtorist.Web.Models.Admin.Auth
{
    public class LoginModel
    {
        [EmailAddress]
        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}