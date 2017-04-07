using System;
using Microsoft.AspNetCore.Mvc;

namespace MvcWebApplication.Controllers {
  public class HomeController : Controller {
    public ActionResult Index()
    {
        return View();
    }
  }
}