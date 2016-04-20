using Owin;
using System.Web.Http;
using System.Web.Http.Cors;

namespace $safeprojectname$
{
    public class WebAppStartup
    {
        public void Configuration(IAppBuilder appBuilder)
        {
            HttpConfiguration config = new HttpConfiguration();

            config.MapHttpAttributeRoutes();
            //TODO: Uncomment if you want to support CORS (Cross-origin Resource Sharing)
            //config.EnableCors();
            //config.EnableCors(new EnableCorsAttribute("*", "*", "*"));

            appBuilder.UseWebApi(config);
            config.EnsureInitialized();
        }
    }
}