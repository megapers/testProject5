using TestProject5.Filters;
using System.Web.Http;

namespace HandlerTemplates
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {

            // Web API configuration and services
            config.Filters.Add(new RouteTimerFilterAttribute("Global"));

            // Web API routes
            config.MapHttpAttributeRoutes();

            // Remove the template routing
            //config.Routes.MapHttpRoute(
            //    name: "DefaultApi",
            //    routeTemplate: "api/{controller}/{id}",
            //    defaults: new { id = RouteParameter.Optional },
            //    constraints: new { id = new RegexBasedConstraintTemplate() },
            //    handler: new DelegatingHandlerTemplate()
            //);
        }
    }
}
