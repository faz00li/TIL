using Microsoft.AspNetCore.Mvc;
using PostOffice.Models;
using System.Collections.Generic;

namespace PostOffice.Controllers
{
  public class HomeController : Controller
  {
    List<Parcel> inventory = Parcel.Inventory();

    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }

    [HttpGet("/new")]
    public ActionResult CreateParcelForm()
    {
      return View();
    }

    [HttpPost("/list")]
    public ActionResult Inventory(string description, int height, int width, int weight)
    {
      Parcel nParcel = new Parcel(description, height, width, weight);
      // return RedirectToAction("Index");
      return View(inventory);
    }

    [HttpGet("/list")]
    public ActionResult Inventory()
    {
      return View(inventory);
    }

    [HttpGet("/parcel")]
    public ActionResult ParcelView(int parcelId)
    {
      return View(parcelId);
    }

  }
}
