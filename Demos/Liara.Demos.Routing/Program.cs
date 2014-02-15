﻿// Author: Prasanna V. Loganathar
// Project: Liara.Demos.Routing
// Copyright (c) Launchark Technologies. All rights reserved.
// See License.txt in the project root for license information.
// 
// Created: 12:15 PM 05-02-2014

using System;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Liara.Formatting;
using Liara.MessageHandlers;
using Microsoft.Owin.Hosting;
using Owin;

namespace Liara.Demos.Routing
{
    public class Program
    {
        private static void Main(string[] args)
        {
            var url = "http://localhost:12345";
            using (WebApp.Start<Startup>(url))
            {
                Console.WriteLine("Listening at {0}", url);
                Process.Start(url);
                Console.ReadLine();
            }
        }
    }

    public class Startup
    {
        public ILiaraConfiguration GetLiaraConfig()
        {
            var config = new LiaraConfiguration();
            //config.Handlers.Add(new HelloHandler());
            config.Build();
            return config;
        }

        public void Configuration(IAppBuilder app)
        {
            app.UseErrorPage();
            app.UseLiara(GetLiaraConfig());
        }
    }

    public class HelloHandler : LiaraMessageHandler
    {
        public override Task ProcessAsync(ILiaraContext context)
        {
            context.Response.WriteAsync("Hello!\r\n");
            context.Response.WriteAsync(context.Request.Info.Uri.ToString());

            return base.ProcessAsync(context);
        }
    }

    //Note: Route Prefix is optional, and will automatically be chained together if nested inside modules.

    [RoutePrefix("/test")]
    public class TestModule : LiaraModule
    {
        [RoutePrefix("/modules")]
        [RoutePrefix("/mod2")]
        public class HelloModule : LiaraModule
        {
            // Path is: /test/modules/hello (or) /test/mod2/hello
            [Route("/hello"), RouteMethod("GET")]
            public void SayHelloMessage()
            {
                Response.WriteAsync("\r\nHello from the module!\r\n");
            }

            [Route("/hello2")]
            public string SayHelloUsingAutoFormat()
            {
                return "\r\nHello!! This comes auto-formatted (Serialized using the formatter).\r\n";
            }
        }
    }


    public class RootModule : LiaraModule
    {
        [Route("/")]
        [RouteMethod("GET, HEAD")]
        [RouteMethod("POST")]
        [Route("/new", routeName: "route2", priority: 5)]
        [RouteMethod("GET", "route2")]
        public object SayHi()
        {
            return "\r\nJust saying hi..";
        }

        [Route("/json"), RouteMethod("POST, GET")]
        public object Json()
        {
            var c = Context.Request.Content;
            try
            {
                return new {c.Name, c.Message};
            }
            catch
            {
                return new {Error = "No name, or message given in the input!"};
            }
        }
    }
}