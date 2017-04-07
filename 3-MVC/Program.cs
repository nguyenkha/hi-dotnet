using System;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Builder;

namespace MvcWebApplication
{
  public class Program
  {
    public static void Main(string[] args)
    {
      var host = new WebHostBuilder()
        .UseKestrel()
        .UseStartup<Startup>()
        .UseUrls("http://*:3000")
        .Build();

      host.Run();
    }
  }
}
