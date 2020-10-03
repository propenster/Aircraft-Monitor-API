using AircraftMonitorAPI.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AircraftMonitorAPI.DataAccess.Repositories
{
    public interface ICardixPatientRepository
    {
        Task<IEnumerable<CardixPatient>> GetAllCardixPatientsAsync();
        Task<CardixPatient> GetCardixPatientById(int Id);
        Task<CardixPatient> GetCardixPatientByPatientId(string PatientId);
        void AddCardixPatient(CardixPatient patient);
        void UpdateCardixPatient(CardixPatient patient);
        void DeleteCardixPatient(int Id);

    }
}
