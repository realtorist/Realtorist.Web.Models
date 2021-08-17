using System.ComponentModel.DataAnnotations;

namespace Realtorist.Web.Models.Admin.Auth
{
    public class RequestPasswordModel
    {
        [EmailAddress]
        [Required]
        public string Email { get; set; }
    }
}