using AircraftMonitorAPI.DataAccess.Repositories;
using AircraftMonitorAPI.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace AircraftMonitorAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AircraftsController : ControllerBase
    {
        private readonly IAircraftRepository _aircraftRepository;

        public AircraftsController(IAircraftRepository aircraftRepository)
        {
            _aircraftRepository = aircraftRepository;
        }

        ///GET api/v1/aircrafts
        [HttpGet]
        public IEnumerable<Aircraft> GetAll()
        {
            return _aircraftRepository.GetAll();
        }

        ///GET api/v1/aircrafts/{id}
        [HttpGet("{id}")]
        public Aircraft GetById(int id)
        {
            return _aircraftRepository.GetById(id);
        }

        ///GET api/v1/aircrafts/{model}
        [HttpGet("{model}")]
        public Aircraft GetByModel(string model)
        {
            return _aircraftRepository.GetByModel(model);
        }

        ///POST api/v1/aircrafts 
        
        [HttpPost]
        public void Post([FromBody] Aircraft aircraft)
        {
            _aircraftRepository.Add(aircraft);
        }

        [HttpPut]
        public void Update(int id, [FromBody] Aircraft aircraft)
        {
            id = aircraft.Id;
            _aircraftRepository.Update(aircraft);
        }

        /// <summary>
        /// DELETE api/v1/aircrafts/{id}
        /// </summary>
        [HttpDelete]
        public void Delete(int id)
        {
            _aircraftRepository.Delete(id);
        }

    }
}
