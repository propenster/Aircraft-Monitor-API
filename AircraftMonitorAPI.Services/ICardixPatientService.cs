using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text;

namespace AircraftMonitorAPI.Services
{
    public interface ICardixPatientService
    {
        Task<IEnumerable<CardixPatient>> GetAllCardixPatients();
    }
}
