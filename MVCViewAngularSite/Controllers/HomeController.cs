using System.Collections.Generic;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;

namespace MVCViewAngularSite.Controllers
{
    public class HomeController : Controller
    {
        [Authorize]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            var ctx = Request.GetOwinContext();

            var claims = new List<Claim> {new Claim("name", "Fjeddo")};
            ctx.Authentication.SignIn(new AuthenticationProperties(), new ClaimsIdentity(claims, DefaultAuthenticationTypes.ApplicationCookie));

            return RedirectToAction("Index");
        }

        public ActionResult Logout()
        {
            Request.GetOwinContext().Authentication.SignOut();

            return View();
        }
    }
}