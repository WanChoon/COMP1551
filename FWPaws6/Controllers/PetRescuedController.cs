using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FWPaws6.Models;
using FWPaws6.ViewModels;

namespace FWPaws6.Controllers
{
    public class PetRescuedController : Controller
    {
        public ViewResult Index()
        {
            var petrecueds = GetPetRescueds();
            return View(petrecueds);
        }

        public ActionResult Details(int id)
        {
            var petrecued = GetPetRescueds().SingleOrDefault(c => c.Id == id);
            if (petrecued == null)
                return HttpNotFound();
            return View(petrecued);
        }

        private IEnumerable<PetRescued> GetPetRescueds()
        {
            return new List<PetRescued>
            {
                new PetRescued { Id = 1, PetName = "Rekt" },
                new PetRescued { Id = 2, PetName = "Rofl" }
            };
        }
        // GET: PetRescued
        public ActionResult Random()
        {
            var rescuer = new Rescuer() { Name = "Ali" };

            var petrescued = new List<PetRescued>
            {
                new PetRescued {PetName = "Rekt"}
            };

            var viewModel = new RandomPetRescuedViewModel
            {
                Rescuer = rescuer,
                PetRescued = petrescued
            };

            return View(viewModel);
        }


    }
}