using System.Web.Http;
using System.Web.Http.Cors;

namespace $safeprojectname$
{
    [RoutePrefix("api")]
    //TODO: Uncomment if you want to support CORS (Cross-origin Resource Sharing)
    //[EnableCors(origins: "*", headers: "*", methods: "*")]
    public class SampleController : ApiController
    {
        [Route("test")]
        [HttpGet]   //TODO: When using CORS the HttpGet attribute can be removed
        public string Test()
        {
            return "Hello world!";
        }
    }
}