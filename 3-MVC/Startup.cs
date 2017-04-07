using System;
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
      // Default MVC route to controller/action
      app.UseMvc(routes => {
        routes.MapRoute(
          name: "default",
          template: "{controller=Home}/{action=Index}/{id?}");
      });
    }
  }
}