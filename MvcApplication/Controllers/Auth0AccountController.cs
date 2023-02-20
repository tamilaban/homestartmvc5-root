using Microsoft.Owin.Security;
using Microsoft.Owin.Security.Cookies;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication.Controllers
{
    public class Auth0AccountController : Controller
    {
         
        [Authorize]
        public void Logout()
        {
            HttpContext.GetOwinContext().Authentication.SignOut(CookieAuthenticationDefaults.AuthenticationType);
            HttpContext.GetOwinContext().Authentication.SignOut("Auth0");
        }
         
    }
}