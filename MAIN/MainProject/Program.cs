using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MainProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /*WebHost.CreateDefaultBuilder(args)
              .UseUrls("http://0.0.0.0:4242")
              .UseWebRoot("public")
              .UseStartup<Startup>()
              .Build()
              .Run();*/
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
