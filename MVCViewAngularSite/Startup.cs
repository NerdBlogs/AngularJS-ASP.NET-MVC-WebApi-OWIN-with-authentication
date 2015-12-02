using Microsoft.AspNet.Identity;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Owin;

namespace MVCViewAngularSite
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // Cookie authentication
            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                LoginPath = new PathString("/Home/Login"),
                Provider = new CookieAuthenticationProvider
                {
                    // Make the Web api not redirect
                    OnApplyRedirect = context =>
                    {
                        if (context.OwinContext.Response.ReasonPhrase != ApiAuthorizeAttribute.ApiUnauthorizedPhrase)
                            context.Response.Redirect(context.RedirectUri);
                    }
                }
            });
        }
    }
}
