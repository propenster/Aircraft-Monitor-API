using System;
using System.Collections.Generic;
using System.Text;

namespace AircraftMonitorAPI.Entities
{
    public class CardixPatient
    {
        public int Id { get; set; }
        public string PatientId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public char Sex { get; set; }

        public string HealthCondition { get; set; }

        public double CurrentTemperature { get; set; }

        public int CurrentBP { get; set; }

        public int CurrentHPR { get; set; }

        public int SleepRestHours { get; set; }

        public int ExcerciseHours { get; set; }

        public string MonitorName { get; set; }
        public string MonitorPhone { get; set; }

        public string MonitorEmail { get; set; }

        public DateTime RegistrationHospital { get; set; }

        public double PatientLocationLat { get; set; }
        public double PatientLocationLong { get; set; }

        public DateTime PatientRegistrationDate { get; set; }

        public DateTime LastCheckUpDate { get; set; }

        public DateTime LastIncidentDate { get; set; }
    }
}
