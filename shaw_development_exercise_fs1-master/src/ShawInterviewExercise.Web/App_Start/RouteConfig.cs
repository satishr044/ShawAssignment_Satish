﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ShawInterviewExercise.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //routes.MapRoute(
            //    name: "Show Detail",
            //    url: "shows/{showName}/",
            //    defaults: new { Controller = "Shows", action = "Details" }
            //);

            routes.MapRoute(
                "Default",
                "{controller}/{action}/{id}",
                new { controller = "Shows", action = "Index", id = UrlParameter.Optional },
                new[] { "ShawInterviewExercise.Web.Controllers" }
            );
        }
    }
}