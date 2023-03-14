using Microsoft.AspNetCore.Mvc;
using SignalRWebapp.Extemsions;
using System.Security.Claims;

namespace SignalRWebapp.Controllers
{
    public class BaseController : Controller
    {
        protected string GetUserId()
        {
            return User.GetUserId();
        }
    }
}
