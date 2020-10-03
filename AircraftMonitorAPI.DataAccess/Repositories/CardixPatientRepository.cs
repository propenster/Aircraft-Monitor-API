using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using AircraftMonitorAPI.Entities;
using Dapper;
using Microsoft.Extensions.Configuration;

namespace AircraftMonitorAPI.DataAccess.Repositories
{
    public class CardixPatientRepository : ICardixPatientRepository
    {
        private readonly IConfiguration _configuration;

        public CardixPatientRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IDbConnection Connection
        {
            get
            {
                return new SqlConnection(_configuration.GetConnectionString("AircraftDBConnection"));
            }
        }

        public void AddCardixPatient(CardixPatient patient)
        {
            try
            {
                using(IDbConnection dbConnection = Connection)
                {
                    dbConnection.Open();
                    DynamicParameters parameters = new DynamicParameters();
                    parameters.Add("PatientId", patient.PatientId);
                    parameters.Add("Name", patient.Name);
                    parameters.Add("Age", patient.Age);
                    parameters.Add("Sex", patient.Sex);
                    parameters.Add("HealthCondition", patient.HealthCondition);
                    parameters.Add("CurrentTemperature", patient.CurrentTemperature);
                    parameters.Add("CurrentBP", patient.CurrentBP);
                    parameters.Add("CurrentHPR", patient.CurrentHPR);
                    parameters.Add("SleepRestHours", patient.SleepRestHours);
                    parameters.Add("ExcerciseHours", patient.ExcerciseHours);
                    parameters.Add("MonitorName", patient.MonitorName);
                    parameters.Add("MonitorPhone", patient.MonitorPhone);
                    parameters.Add("MonitorEmail", patient.MonitorEmail);
                    parameters.Add("RegistrationHospital", patient.RegistrationHospital);
                    parameters.Add("PatientLocationLat", patient.PatientLocationLat);
                    parameters.Add("PatientLocationLong", patient.PatientLocationLong);
                    parameters.Add("PatientRegistrationDate", patient.PatientRegistrationDate);
                    parameters.Add("LastCheckUpDate", patient.LastCheckUpDate);
                    parameters.Add("LastIncidentDate", patient.LastIncidentDate);

                    SqlMapper.Execute(dbConnection, "AddNewCardixPatient", param: parameters, commandType: CommandType.StoredProcedure);
                }
            }catch(Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteCardixPatient(int Id)
        {
            try
            {
                using(IDbConnection dbConnection = Connection)
                {
                    dbConnection.Open();
                    DynamicParameters parameters = new DynamicParameters();
                    parameters.Add("Id", Id);
                    SqlMapper.Execute(dbConnection, "DeleteCardixPatient", parameters, commandType: CommandType.StoredProcedure);
                }
            }catch(Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IEnumerable<CardixPatient>> GetAllCardixPatientsAsync()
        {
            try
            {
                using(IDbConnection dbConnection = Connection)
                {
                    dbConnection.Open();
                    return await SqlMapper.QueryAsync<CardixPatient>(dbConnection, "GetAllCardixPatients", commandType: CommandType.StoredProcedure);
                }
            }catch(Exception ex)
            {
                throw ex;
            }
        }

        public async Task<CardixPatient> GetCardixPatientById(int Id)
        {
            try
            {
                using(IDbConnection dbConnection = Connection)
                {
                    dbConnection.Open();
                    DynamicParameters parameters = new DynamicParameters();
                    parameters.Add("Id", Id);
                    return await SqlMapper.QuerySingleOrDefaultAsync<CardixPatient>(dbConnection, "GetCardixPatientById", parameters, commandType: CommandType.StoredProcedure);
                }
            }catch(Exception ex)
            {
                throw ex;
            }
        }

        public async Task<CardixPatient> GetCardixPatientByPatientId(string PatientId)
        {
            try
            {
                using (IDbConnection dbConnection = Connection)
                {
                    dbConnection.Open();
                    DynamicParameters parameters = new DynamicParameters();
                    parameters.Add("PatientId", PatientId);
                    return await SqlMapper.QuerySingleOrDefaultAsync<CardixPatient>(dbConnection, "GetCardixPatientByPatientId", parameters, commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateCardixPatient(CardixPatient patient)
        {
            try
            {
                using (IDbConnection dbConnection = Connection)
                {
                    dbConnection.Open();
                    DynamicParameters parameters = new DynamicParameters();
                    parameters.Add("Id", patient.Id);
                    parameters.Add("PatientId", patient.PatientId);
                    parameters.Add("Name", patient.Name);
                    parameters.Add("Age", patient.Age);
                    parameters.Add("Sex", patient.Sex);
                    parameters.Add("HealthCondition", patient.HealthCondition);
                    parameters.Add("CurrentTemperature", patient.CurrentTemperature);
                    parameters.Add("CurrentBP", patient.CurrentBP);
                    parameters.Add("CurrentHPR", patient.CurrentHPR);
                    parameters.Add("SleepRestHours", patient.SleepRestHours);
                    parameters.Add("ExcerciseHours", patient.ExcerciseHours);
                    parameters.Add("MonitorName", patient.MonitorName);
                    parameters.Add("MonitorPhone", patient.MonitorPhone);
                    parameters.Add("MonitorEmail", patient.MonitorEmail);
                    parameters.Add("RegistrationHospital", patient.RegistrationHospital);
                    parameters.Add("PatientLocationLat", patient.PatientLocationLat);
                    parameters.Add("PatientLocationLong", patient.PatientLocationLong);
                    parameters.Add("PatientRegistrationDate", patient.PatientRegistrationDate);
                    parameters.Add("LastCheckUpDate", patient.LastCheckUpDate);
                    parameters.Add("LastIncidentDate", patient.LastIncidentDate);

                    SqlMapper.Execute(dbConnection, "UpdateCardixPatient", param: parameters, commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
