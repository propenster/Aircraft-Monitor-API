using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AircraftMonitorAPI.Entities;
using Dapper;
using Microsoft.Extensions.Configuration;

namespace AircraftMonitorAPI.DataAccess.Repositories
{
    public class AircraftRepository : IAircraftRepository
    {
        private readonly string _connectionString;

        public AircraftRepository()
        {
            _connectionString = "Data Source=XXX\\SQLEXPRESS;Initial Catalog=AircraftDB;Integrated Security=True";
        }

        public IDbConnection Connection
        {
            get
            {
                return new SqlConnection(_connectionString);
            }
        }
        //Post an Aircraft resource...
        public void Add(Aircraft aircraft)
        {
            using(IDbConnection dbConnection = Connection)
            {
                string query = @"INSERT INTO Aircraft 
                    (Id,
                    Manufacturer,
                    Model,
                    RegistrationNumber,
                    FirstClassCapacity,
                    RegularClassCapacity,
                    CrewCapacity,
                    ManufactureDate,
                    NumberOfEngines,
                    EmptyWeight,
                    MaxTakeOffWeight) VALUES(Id,
                    Manufacturer,
                    Model,
                    RegistrationNumber,
                    FirstClassCapacity,
                    RegularClassCapacity,
                    CrewCapacity,
                    ManufactureDate,
                    NumberOfEngines,
                    EmptyWeight,
                    MaxTakeOffWeight)";

                dbConnection.Open();
                dbConnection.Execute(query, aircraft);
            }
        }

        public void Delete(int id)
        {
            using(IDbConnection dbConnection = Connection)
            {
                string query = @"DELETE FROM Aircraft WHERE Id=@Id";
                dbConnection.Open();
                dbConnection.Execute(query, new { Id = id });
            }
        }

        public void Update(Aircraft aircraft)
        {
            using(IDbConnection dbConnection = Connection)
            {
                string query = @"UPDATE Aircraft SET 
                    Id=@Id,
                    Manufacturer=@Manufacturer,
                    Model=@Model,
                    RegistrationNumber=@RegistrationNumber,
                    FirstClassCapacity=@FirstClassCapacity,
                    RegularClassCapacity=@RegularClassCapacity,
                    CrewCapacity=@CrewCapacity,
                    ManufactureDate=@ManufactureDate,
                    NumberOfEngines=@NumberOfEngines,
                    EmptyWeight=@EmptyWeight,
                    MaxTakeOffWeight=@MaxTakeOffWeight";

                dbConnection.Open();
                dbConnection.Query(query, aircraft);
            }
        }

        public IEnumerable<Aircraft> GetAll()
        {
            using (IDbConnection dbConnection = Connection)
            {
                string query = @"SELECT * FROM Aircraft";
                dbConnection.Open();
                return dbConnection.Query<Aircraft>(query);
            }
        }

        public Aircraft GetById(int id)
        {
            using(IDbConnection dbConnection = Connection)
            {
                string query = @"SELECT * FROM Aircraft WHERE Id = @Id";
                dbConnection.Open();
                return dbConnection.Query<Aircraft>(query, new { Id = id }).FirstOrDefault();
            }
        }

        public Aircraft GetByModel(string model)
        {
            using(IDbConnection dbConnection = Connection)
            {
                string query = @"SELECT * Aircraft WHERE Model=@Model";
                dbConnection.Open();
                return dbConnection.Query<Aircraft>(query, new { Model = model }).FirstOrDefault();
            }
        }
    }
}
