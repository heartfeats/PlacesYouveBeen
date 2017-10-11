using Microsoft.AspNetCore.Mvc;
using PlacesYouveBeen.Models;
using System.Collections.Generic;

namespace PlacesYouveBeen.Controllers
{
    public class HomeController : Controller
    {

        [Route("/")]
        public ActionResult Index()
        {
          return View();
        }

        [Route("/place/list")]
        public ActionResult PlaceList()
        {
          List<Place> allPlaces = Place.GetAll();
          return View(allPlaces);
        }

        [HttpPost("/place/create")]
        public ActionResult CreatePlace()
        {
          Place newPlace = new Place (Request.Form["new-city"], Request.Form["new-country"], int.Parse(Request.Form["new-year"]), Request.Form["new-photo"]);
          newPlace.Save();
          return View(newPlace);
        }

        [HttpPost("/place/list/clear")]
        public ActionResult PlaceListClear()
        {
            Place.ClearAll();
            return View();
        }

    }
}
