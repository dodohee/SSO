using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MainWeb.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            if (!HttpContext.User.Identity.IsAuthenticated)
            {
                return Challenge(OpenIdConnectDefaults.AuthenticationScheme);
            }

            return RedirectToAction("Index", "Home");
        }

        public IActionResult OktaLogin(string userId)
        {
            var uid = userId;

            if (!HttpContext.User.Identity.IsAuthenticated)
            {
                return Challenge(OpenIdConnectDefaults.AuthenticationScheme);
            }

            return RedirectToAction("Index", "Home");
        }

        public IActionResult OktaLoginFail(string userId)
        {
            var uid = userId;

            // this is custom behavior that enables to handle various situation
            if (uid == "gooduser@domain.com")
            {
                return RedirectToAction("Login2", "Account", "message=good");
            }
            else if(uid == "allowed")
            {
                return RedirectToAction("Login3", "Account");
            }
            else
            {
                return RedirectToAction("Login4", "Account");
            }
        }

        public IActionResult Login2()
        {
            return View();
        }

        public IActionResult Login3()
        {
            return View();
        }

        public IActionResult Login4()
        {
            return View();
        }

        public IActionResult Logout()
        {
            if (HttpContext.User.Identity.IsAuthenticated)
            {
                return SignOut(CookieAuthenticationDefaults.AuthenticationScheme, OpenIdConnectDefaults.AuthenticationScheme);
            }

            if (HttpContext.User.Identity.IsAuthenticated)
            {
                return SignOut(CookieAuthenticationDefaults.AuthenticationScheme, OpenIdConnectDefaults.AuthenticationScheme);
            }

            return RedirectToAction("Index", "Home");
        }

        [Authorize]
        public IActionResult Claims()
        {
            return View();
        }
    }
}
