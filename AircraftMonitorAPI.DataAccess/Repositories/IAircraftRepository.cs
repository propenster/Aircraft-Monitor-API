using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AircraftMonitorAPI.Entities;

namespace AircraftMonitorAPI.DataAccess.Repositories
{
    public interface IAircraftRepository
    {
        Aircraft GetByModel(string model);
        IEnumerable<Aircraft> GetAll();
        Aircraft GetById(int id);
        void Add(Aircraft aircraft);
        void Update(Aircraft aircraft);
        void Delete(int id);

    }
}
