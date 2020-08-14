using BakedGoods.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace BakedGoods.Controllers
{
  public class FlavorsController : Controller
  {
    private readonly BakedGoodsContext _db;
    public FlavorsController(BakedGoodsContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Flavor> model = _db.Flavors.ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      ViewBag.FlavorId = new SelectList(_db.Flavors, "FlavorId", "Name");
      return View();
    }

    [HttpPost]
    public ActionResult Create(Flavor flavor, int PastryId)
    {
      _db.Flavors.Add(flavor);
      if(PastryId != 0)
      {
        _db.PastryFlavor.Add(new PastryFlavor() {PastryId = PastryId, FlavorId = flavor.FlavorId});
      }
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
      public ActionResult Show(int id)
    {
      var thisFlavor = _db.Flavors
      .Include(flavor => flavor.Pastries)
      .ThenInclude(join => join.Pastry)
      .FirstOrDefault(flavor => flavor.FlavorId == id);
      return View(thisFlavor);
    }
    public ActionResult Edit(int id)
    {
      var thisFlavor = _db.Flavors.FirstOrDefault(flavors => flavors.FlavorId == id);
      return View(thisFlavor);
    }

    [HttpPost]
    public ActionResult Edit(Flavor flavor)
    {
      _db.Entry(flavor).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Show", new { id = flavor.FlavorId});
    }

    public ActionResult AddPastry(int id)
    {
      var thisFlavor = _db.Flavors.FirstOrDefault(flavors => flavors.FlavorId == id);
      ViewBag.PastryId = new SelectList(_db.Pastries, "PastryId", "Name");
      return View(thisFlavor);
    }

    [HttpPost]
    public ActionResult AddPastry(Flavor flavor, int PastryId)
    {
      if(PastryId != 0 && !_db.PastryFlavor.Any(x => x.PastryId == PastryId && x.FlavorId == flavor.FlavorId))
      {
        _db.PastryFlavor.Add(new PastryFlavor() { PastryId = PastryId, FlavorId = flavor.FlavorId });
      }
      _db.SaveChanges();
      return RedirectToAction("Show", new { id = flavor.FlavorId});
    }

    public ActionResult Delete(int id)
    {
      var thisFlavor = _db.Flavors.FirstOrDefault(flavors => flavors.FlavorId == id);
      return View(thisFlavor);
    }

    [HttpPost]
    public ActionResult RemovePastry(int joinId)
    {
      var joinEntry = _db.PastryFlavor.FirstOrDefault(entry => entry.PastryFlavorId == joinId);
      _db.PastryFlavor.Remove(joinEntry);
      _db.SaveChanges();
      return RedirectToAction("Show", new { id = joinEntry.FlavorId });
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisFlavor = _db.Flavors.FirstOrDefault(flavors => flavors.FlavorId == id);
      _db.Flavors.Remove(thisFlavor);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}