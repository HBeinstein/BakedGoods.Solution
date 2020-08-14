using System.Reflection.PortableExecutable;
using Microsoft.AspNetCore.Mvc;
using BakedGoods.Models;
using System.Collections.Generic;
using System.Linq;

namespace BakedGoods.Controllers
{
  public class HomeController : Controller
  {
    private readonly BakedGoodsContext _db;

    public HomeController(BakedGoodsContext db)
    {
      _db = db;
    }

    [HttpGet("/")]
    public ActionResult Index()
    {
      ViewBag.Pastries = _db.Pastries.ToList();
      ViewBag.Flavors = _db.Flavors.ToList();
      return View();
    }

  }
}