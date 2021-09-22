using System;

namespace Realtorist.Web.Models.Attributes
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class RequireAuthorizationAttribute : Attribute
    {
        
    }
}