using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using CitiesAPI.ViewModels;
using CitiesAPI.Model;
using CitiesAPI.Controllers;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;

namespace CitiesAPI.Controllers
{
    [Route("/api/city")]
    public class CityController : ControllerBase
    {
        private readonly IStorage _storage;
        private readonly ILogger _logger;
        public CityController(IStorage storage, ILogger<CityController> logger)
        {
            _storage = storage;
            _logger = logger;
        }

        [HttpGet]
        public IActionResult List()
        {
            var list = _storage.
                FindAll().
                Select(city => new CityInfoViewModel(city)).
                ToList();

            return Ok(list);
        }
        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            var item = _storage.FindById(id);
            if (item == null)
            {
                _logger.LogWarning("Not existing city requested");
                return NotFound();
            }
            return Ok(new CityDetailViewModel(item));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            var item = _storage.FindById(id);
            if (item == null)
            {
                _logger.LogWarning($"Can't delete, because city with id {id} not found");
                return NotFound();
            }
            _storage.Delete(id);
            return NoContent();
        }

        [HttpPut("{id}")]

        public IActionResult Update(Guid id, [FromBody] UpdateCityViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                var target = _storage.FindById(id);
                var item = new City(
                    target.Id,
                    target.Title,
                    model.Description.Capitalize().Trim(),
                    model.Population
                    );
                _storage.Update(item);

                return Ok(new CityDetailViewModel(item));
            }
            catch (ArgumentNullException)
            {
                return BadRequest();
            }
            catch (ArgumentException)
            {
                return NotFound();
            }
        }

        [HttpPost]
        public IActionResult Create([FromBody]CreateCityViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var city = new City(
                Guid.NewGuid(),
                model.Title.Trim(),      //санитизация
                model.Description.Trim(),
                model.Population);
            var duplicate = _storage.FindByTitle(city.Title);
            if (duplicate != null)
            {
                _logger.LogWarning("Duplicate city");
                return Conflict();
            }
            _storage.Create(city);
            return Ok(new CityDetailViewModel(city));
            //return Created(city);
        }
    }
}
