using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FWPaws6.Models;

namespace FWPaws6.ViewModels
{
    public class RandomPetRescuedViewModel
    {
        public List<PetRescued> PetRescued { get; set; }
        public Rescuer Rescuer { get; set; }
    }
}