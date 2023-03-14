using System.Security.Claims;
using Microsoft.AspNet.Identity;

namespace SignalRWebapp.Extemsions
{
    public static class ClaimsPrincipalExtensions
    {
        public static string GetUserId(this ClaimsPrincipal @this)
        {
            return @this.Identity.GetUserId();
        }
    }
}
