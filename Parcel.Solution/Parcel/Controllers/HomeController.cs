using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Parcels.Models;

namespace Parcels.Controllers
{
    public class HomeController : Controller
    {
      [HttpGet("/home")]
      public ActionResult Index()
      {
        List<Parcel> allParcel = Parcel.GetAll();
        return View(allParcel);
      }

      [HttpPost("/home")]
      public ActionResult Create(string name, int width, int height, int length, int weight, int distance)
      {
        Parcel myParcel = new Parcel(name, width, height, length, weight, distance);
        return RedirectToAction("Index");
      }
    }
}
