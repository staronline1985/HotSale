﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using System.Web.Http;


namespace Web.API
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            var _formatter = GlobalConfiguration.Configuration.Formatters;
            _formatter.Remove(_formatter.XmlFormatter);
            System.Web.Routing.RouteTable.Routes.MapHttpRoute(
               name: "DefaultApi",
               routeTemplate: "api/{controller}/{id}",
               defaults: new { id = System.Web.Http.RouteParameter.Optional });
        }
    }
}