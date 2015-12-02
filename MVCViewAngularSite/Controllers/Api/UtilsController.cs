using System;
using System.Web.Http;

namespace MVCViewAngularSite.Controllers.Api
{
    [ApiAuthorize]
    public class UtilsController : ApiController
    {
        [Route("api/utils/time")]
        public IHttpActionResult GetServerTime()
        {
            return Ok(DateTimeOffset.UtcNow);
        }
    }
}
