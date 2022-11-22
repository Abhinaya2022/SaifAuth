using HospitalApp.DBHelper;
using HospitalApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalApp.Controllers
{
    public class AppointmentController : Controller
    {
        [HttpGet]
        public IActionResult List()
        {
            List<Appointment> alist = AppointmentHelper.GetList();
            return View(alist);
        }
        [HttpGet]
        public IActionResult Create(int id)
        {

           // ViewBag.Appointments=AppointmentHelper.GetAppointmentId(id);
            ViewBag.Symptoms=new List<string> { "Fever", "Headache", "Body Pain", "No Appetite", "Low Energey","High BP","Low BP" };
           // ViewBag.PatientId=new List<string> { "1", "2", "Body Pain", "No Appetite", "Low Energey", "High BP", "Low BP" };
            return View();
        }
        [HttpPost]
        public IActionResult Create(Appointment appointment)
        {
            
          //  appointment.PatientName = Request.Form["PatientName"];
    
            appointment.Symptoms = Request.Form["Symptoms"];
            AppointmentHelper.Create(appointment);
            return RedirectToAction("List");
        }
    }
}
