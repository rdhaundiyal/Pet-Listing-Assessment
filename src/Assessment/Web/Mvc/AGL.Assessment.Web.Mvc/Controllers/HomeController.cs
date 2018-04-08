using AGL.Assessment.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AGL.Assessment.Domain.Model;
using AGL.Assessment.Web.Mvc.Mapper;
using AGL.Assessment.Web.Mvc.Models;

namespace AGL.Assessment.Web.Mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPeopleDomain _peopleDomain;
        public HomeController(IPeopleDomain peopleDomain)
        {
            _peopleDomain = peopleDomain;
        }

        public ActionResult Pet(string petType)
        {
            var peopleWithCat = _peopleDomain.GetOwnersByPetType(petType);
            var model = peopleWithCat.ToOwnerGenderWisePetsViewModel(petType, SortOrder.Descending);
            return View(model);
        }
    }
}