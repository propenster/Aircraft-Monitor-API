using AircraftMonitorAPI.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AircraftMonitorAPI.Services
{
    public interface ICardixPatientService
    {
        Task<IEnumerable<CardixPatient>> GetAllCardixPatients();
        Task<CardixPatient> GetCardixPatientById(int Id);
        Task<CardixPatient> GetCardixPatientBypatientId(string PatientId);
        void AddCardixPatient(CardixPatient patient);
        void UpdateCardixPatient(CardixPatient patient);
        void DeleteCardixPatient(int Id);
    }
}
