using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Controllers;

namespace MVCViewAngularSite
{
    /// <summary>
    /// Override authorize attribute, 
    /// uses ReasonPhrase to prevent redirects in the unauthorized redirection
    /// </summary>
    public class ApiAuthorizeAttribute : AuthorizeAttribute
    {
        public const string ApiUnauthorizedPhrase = "Api Unauthorized";

        protected override void HandleUnauthorizedRequest(HttpActionContext actionContext)
        {
            var response = actionContext.Request.CreateResponse(HttpStatusCode.Unauthorized);
            response.ReasonPhrase = ApiUnauthorizedPhrase;
            actionContext.Response = response;
        }
    }
}