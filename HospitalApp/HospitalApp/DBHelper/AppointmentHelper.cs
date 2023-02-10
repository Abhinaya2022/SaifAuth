using HospitalApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalApp.DBHelper
{
    public class AppointmentHelper
    {
        public static List<Appointment> GetList()
        {
            HospitalContext db = new HospitalContext();
            List<Appointment> aList = db.Appointments.ToList();
            return aList;
        }
        public static Appointment Create(Appointment appointment)
        {
            HospitalContext db = new HospitalContext();
            db.Appointments.Add(appointment);
            db.SaveChanges();
            return appointment;
        }
        public static Appointment GetAppointmentId(int id)
        {
            HospitalContext db = new HospitalContext();
            Appointment appointment = db.Appointments.FirstOrDefault(item => item.Id == id);
            return appointment;
        }
    }
}
