using System;
using System.Collections.Generic;

#nullable disable

namespace HospitalApp.Models
{
    public partial class Patient
    {
        public Patient()
        {
            Appointments = new HashSet<Appointment>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string City { get; set; }

        public virtual ICollection<Appointment> Appointments { get; set; }
    }
}
