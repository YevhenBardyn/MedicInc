using MedicInc.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MedicInc.Controllers
{
    public class HomeController : Controller
    {
        DiseaseService diseaseService = new DiseaseService();
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Search(string symptom)
        {
            return View(diseaseService.SerchDiseaseInDB(symptom));
        }
    }
}