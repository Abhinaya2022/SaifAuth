using HospitalApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalApp.DBHelper
{
    public class PatientHelper
    {
        public static List<Patient> GetList()
        {
            HospitalContext db = new HospitalContext();
            List<Patient> aList = db.Patients.ToList();
            return aList;
        }
        public static Patient Create(Patient patient)
        {
            HospitalContext db = new HospitalContext();
            db.Patients.Add(patient);
            db.SaveChanges();
            return patient;
        }
        public static Patient GetPatientId(int id)
        {
            HospitalContext db = new HospitalContext();
            Patient patient = db.Patients.FirstOrDefault(item => item.Id == id);
            return patient;
        }
    }
}
