using System;

namespace Realtorist.Web.Models.Admin.Auth
{
    public class TokenContainer
    {
        public DateTime ExpirationTimeUtc { get; set; }

        public Guid Guid { get; set; }

        public string Email { get; set; }
    }
}