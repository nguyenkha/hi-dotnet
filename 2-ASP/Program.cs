using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace WebApplication
{
  public class Program
  {
    public static void Main(string[] args)
    {
      var host = new WebHostBuilder()
        .UseKestrel()
        .Configure(app =>
        {
            app.Run(async (context) => {
              await context.Response.WriteAsync("Hello world from ASP.net Core");
            });
        })
        .UseUrls("http://*:3000")
        .Build();

      host.Run();
    }
  }
}
