using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace SignalRWebapp.Controllers
{
    public class AccountController : Controller
    {
        private SignInManager<User> signInManager;
        private UserManager<User> userManager;

        public AccountController(UserManager<User> userManager,SignInManager<User> signInManager)
        {
            this.signInManager= signInManager;
            this.userManager = userManager;
        }
        [HttpGet]
        public IActionResult Login() => View();
        [HttpPost]

        public async Task<IActionResult> Login(string username, string password)
        {
            var user = await userManager.FindByNameAsync(username);

            if (user != null)
            {
                var result = await signInManager.PasswordSignInAsync(user, password, false, false);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }
            }

            return RedirectToAction("Login", "Account");
        }

        [HttpGet]
        public IActionResult Register() => View();
        [HttpPost]

        public async Task<IActionResult> Register(string username, string password)
        {
            var user = new User
            {
                UserName = username
            };

            var result = await userManager.CreateAsync(user, password);

            if (result.Succeeded)
            {
                await signInManager.SignInAsync(user, false);

                return RedirectToAction("Index", "Home");
            }

            return RedirectToAction("Register", "Account");
        }

        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Login", "Account");
        }
    }
}
