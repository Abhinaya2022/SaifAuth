using HospitalApp.DBHelper;
using HospitalApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalApp.Controllers
{
    public class PatientController : Controller
    {

        [HttpGet]
        public IActionResult List()
        {
            List<Patient> plist = PatientHelper.GetList();
            return View(plist);
        }
        [HttpGet]
        public IActionResult Create(int id)
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Patient patient)
        {
            PatientHelper.Create(patient);
            return RedirectToAction("List");
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            Patient patient = PatientHelper.GetPatientId(id);
            return View(patient);
        }
    }
}
