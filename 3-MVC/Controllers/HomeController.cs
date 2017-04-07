using System;
using Microsoft.AspNetCore.Mvc;

namespace MvcWebApplication.Controllers {
  public class HomeController : Controller {
    public string Index()
    {
        return "Hello world from ASP.net MVC controller";
    }
  }
}