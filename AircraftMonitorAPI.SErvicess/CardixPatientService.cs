using AircraftMonitorAPI.DataAccess.Repositories;
using AircraftMonitorAPI.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AircraftMonitorAPI.Services
{
    public class CardixPatientService : ICardixPatientService
    {

        protected readonly ICardixPatientRepository _patientRepository;

        public CardixPatientService(ICardixPatientRepository patientRepository)
        {
            _patientRepository = patientRepository;
        }

        public void AddCardixPatient(CardixPatient patient)
        {
            _patientRepository.AddCardixPatient(patient);
        }

        public void DeleteCardixPatient(int Id)
        {
            _patientRepository.DeleteCardixPatient(Id);
        }

        public async Task<IEnumerable<CardixPatient>> GetAllCardixPatients()
        {
            return await _patientRepository.GetAllCardixPatientsAsync();
        }

        public async Task<CardixPatient> GetCardixPatientById(int Id)
        {
            return await _patientRepository.GetCardixPatientById(Id);
        }

        public async Task<CardixPatient> GetCardixPatientBypatientId(string PatientId)
        {
            return await _patientRepository.GetCardixPatientByPatientId(PatientId);
        }

        public void UpdateCardixPatient(CardixPatient patient)
        {
            _patientRepository.UpdateCardixPatient(patient);
        }
    }
}
