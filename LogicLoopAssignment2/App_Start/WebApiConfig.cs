using LogicLoopAssignment2.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace LogicLoopAssignment2
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.Filters.Add(new BasicAuthenticationAttribute());
            config.Filters.Add(new CustomExceptionFilter());
           
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
