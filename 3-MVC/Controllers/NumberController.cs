using System;
using Microsoft.AspNetCore.Mvc;

namespace MvcWebApplication.Controllers {
  [Route("api/[controller]")]
  public class NumberController : Controller {
    [HttpGet]
    public int[] Get()
    {
        return new int[] { 0, 1, 2, 3 };
    }
    [HttpGet("{id}")]
    public int Get(int id) {
      return id;
    }
  }
}