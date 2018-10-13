using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FWPaws6.Models;

namespace FWPaws6.Controllers
{
    public class RescuerController : Controller
    {
        public ViewResult Index()
        {
            var rescuers = GetRescuers();
            return View(rescuers);
        }
        public ActionResult Details(int id)
        {
            var rescuer = GetRescuers().SingleOrDefault(c => c.Id == id);
            if (rescuer == null)
                return HttpNotFound();
            return View(rescuer);
        }
        private IEnumerable<Rescuer> GetRescuers()
        {
            return new List<Rescuer>
            {
                new Rescuer { Id = 1, Name = "John Smith" },
                new Rescuer { Id = 2, Name = "Mary Williams" }
            };
        }
    }
}