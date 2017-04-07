using System;
using System.IO;
using Microsoft.Extensions.FileProviders; 
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace MvcWebApplication {
  public class Startup {
    public void ConfigureServices(IServiceCollection services)
    {
      // MVC service: MVC Core, View, Razor, JsonFormatter, CORS...
      services.AddMvc();
    }
    public void Configure(IApplicationBuilder app) {
      // Serve static files
      app.UseStaticFiles(new StaticFileOptions() {
        FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), @"public")),
        RequestPath = ""
      });

      // Default MVC route to controller/action
      app.UseMvc(routes => {
        routes.MapRoute(
          name: "default",
          template: "{controller=Home}/{action=Index}/{id?}");
      });
    }
  }
}