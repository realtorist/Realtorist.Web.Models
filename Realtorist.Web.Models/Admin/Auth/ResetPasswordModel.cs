using System;
using System.ComponentModel.DataAnnotations;

namespace Realtorist.Web.Models.Admin.Auth
{
    public class ResetPasswordModel
    {
        [MinLength(6)]
        public string Password { get; set; }

        [Compare(nameof(Password))]
        public string ConfirmPassword { get; set; }

        public Guid Id { get; set; }
    }
}