using System;
using System.Collections.Generic;

#nullable disable

namespace HospitalApp.Models
{
    public partial class Appointment
    {
        public int Id { get; set; }
        public int PatientId { get; set; }
        public string PatientName { get; set; }
        public decimal Temperature { get; set; }
        public string Bp { get; set; }
        public string Symptoms { get; set; }
        public DateTime AppointmentDate { get; set; }

        public virtual Patient Patient { get; set; }
    }
}
