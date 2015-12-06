using System;
using System.Runtime.InteropServices;
using System.Web.Http;

namespace MVCViewAngularSite.Controllers.Api
{
    [ApiAuthorize]
    public class UtilsController : ApiController
    {
        [Route("api/utils/time", Name = "GetServerTime")]
        public IHttpActionResult GetServerTime()
        {
            return Ok(DateTimeOffset.UtcNow);
        }
    }
}
