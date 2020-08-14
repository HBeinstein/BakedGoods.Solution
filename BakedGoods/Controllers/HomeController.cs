using System.Reflection.PortableExecutable;
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
      ViewBag.Pastries = _db.Pastries.ToList();
      ViewBag.Flavors = _db.Flavors.ToList();
      return View();
    }

  }
}