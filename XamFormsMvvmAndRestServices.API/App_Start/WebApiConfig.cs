using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace XamFormsMvvmAndRestServices.API
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
            //config.Formatters.JsonFormatter
            //.SerializerSettings
            //.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
            

            Seed();

        }
        


        private static void Seed()
        {

            
    }
    }
    
}
