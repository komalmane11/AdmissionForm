using AdmissionFormUsing_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace AdmissionFormUsing_MVC.Controllers
{
    public class AdmissionController : Controller
    {
        //Get
        public IActionResult Index()
        {
            return View();
        }

        //Post Addmission
        [HttpPost]
        public IActionResult Submit(Admission model)
        {
            if (ModelState.IsValid)
            {
                TempData["SuccessMessage"] = "Admission is successfully done!";
                return RedirectToAction("Homepage");
            }

            return View("Index", model);
        }

        //homepage after succesfully admission
        public ActionResult Homepage()
        {
            return View();
        }
    }
}
