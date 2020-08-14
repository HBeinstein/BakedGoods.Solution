using Microsoft.AspNetCore.Mvc;
using BakedGoods.Models;
using System.Collections.Generic;

namespace BakedGoods.Controllers
{
  public class HomeController : Controller
  {

    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }

  }
}