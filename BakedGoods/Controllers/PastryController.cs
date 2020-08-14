using BakedGoods.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace BakedGoods.Controllers
{
  public class PastriesController : Controller
  {
    private readonly BakedGoodsContext _db;
    public PastriesController(BakedGoodsContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Pastry> model = _db.Pastries.ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Pastry pastry)
    {
      _db.Pastries.Add(pastry);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
    
    public ActionResult Show(int id)
    {
      var thisPastry = _db.Pastries
        .Include(pastry => pastry.Flavors)
        .ThenInclude(join => join.Flavor)
        .FirstOrDefault(pastry => pastry.PastryId == id);
        return View(thisPastry);
    }

    public ActionResult Edit(int id)
    {
      var thisPastry = _db.Pastries.FirstOrDefault(Pastry => Pastry.PastryId == id);
      return View(thisPastry);
    }

    [HttpPost]
    public ActionResult Edit(Pastry pastry)
    {
      _db.Entry(pastry).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult AddFlavor(int id)
    {
      var thisPastry = _db.Pastries.FirstOrDefault(pastries => pastries.PastryId == id);
      ViewBag.FlavorId = new SelectList(_db.Flavors, "FlavorId", "Name");
      return View(thisPastry);
    }

    [HttpPost]
    public ActionResult AddFlavor(Pastry pastry, int FlavorId)
    {
      if(FlavorId != 0 && !_db.PastryFlavor.Any(x => x.FlavorId == FlavorId && x.PastryId == pastry.PastryId))
      {
        _db.PastryFlavor.Add(new PastryFlavor() { FlavorId = FlavorId, PastryId = pastry.PastryId});
      }
      _db.SaveChanges();
      return RedirectToAction("Show", new { id = pastry.PastryId});
    }

    public ActionResult Delete(int id)
    {
      var thisPastry = _db.Pastries.FirstOrDefault(pastry => pastry.PastryId == id);
      return View(thisPastry);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisPastry = _db.Pastries.FirstOrDefault(pastry => pastry.PastryId == id);
      _db.Pastries.Remove(thisPastry);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    [HttpPost]
    public ActionResult RemoveFlavor(int joinId)
    {
      var joinEntry = _db.PastryFlavor.FirstOrDefault(entry => entry.PastryFlavorId == joinId);
      _db.PastryFlavor.Remove(joinEntry);
      _db.SaveChanges();
      return RedirectToAction("Show", new { id = joinEntry.PastryId});
    }
  }
}