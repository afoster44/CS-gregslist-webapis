using System.Collections.Generic;
using System.Linq;
using gregslist.db;
using gregslist.Models;
using gregslist.Services;
using Microsoft.AspNetCore.Mvc;

namespace gregslist.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CarsController : ControllerBase
    {
        private readonly CarsService _service;

        public CarsController(CarsService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Car>> Get()
        {
            try
            {
                return Ok(_service.Get());
            }
            catch (System.Exception err)
            {
                return BadRequest(err);
            }
        }

        [HttpPost]
        public ActionResult<Car> Create([FromBody] Car newCar)
        {
            try
            {
                var car = _service.Create(newCar);
                return Ok(car);
            }
            catch (System.Exception err)
            {
                return BadRequest(err.Message);
            }
        }

        [HttpGet("{Id}")]
        public ActionResult<Car> Get(int Id)
        {
            try
            {
                return Ok(_service.Get(Id));
            }
            catch (System.Exception err)
            {
                return BadRequest(err);
            }
        }

        [HttpPut("{Id}")]
        public ActionResult<Car> Edit(int Id, [FromBody] Car car)
        {
            try
            {
                car.Id = Id;
                return Ok(_service.Edit(Id, car));
            }
            catch (System.Exception err)
            {
                return BadRequest(err);
            }
        }

        [HttpDelete("{Id}")]
        public ActionResult<Car> Delete(string Id)
        {
            try
            {
                return Ok(_service);
            }
            catch (System.Exception err)
            {
                return BadRequest(err);
            }
        }
    }
}