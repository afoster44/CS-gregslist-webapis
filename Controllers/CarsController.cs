using System.Collections.Generic;
using gregslist.db;
using gregslist.Models;
using Microsoft.AspNetCore.Mvc;

namespace gregslist.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CarsController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<Car>> Get()
        {
            try
            {
                return Ok(FakeDb.Cars);
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
                FakeDb.Cars.Add(newCar);
                return Ok(newCar);
            }
            catch (System.Exception err)
            {
                return BadRequest(err);
            }
        }

        [HttpGet("{Id}")]
        public ActionResult<Car> GetById(string Id)
        {
            try
            {
                Car foundCar = FakeDb.Cars.Find(c => c.Id == Id);
                if (foundCar == null)
                {
                    throw new System.Exception("Sorry but we can not find that car.");
                }
                return Ok(foundCar);
            }
            catch (System.Exception err)
            {
                return BadRequest(err);
            }
        }

        [HttpPut("{Id}")]
        public ActionResult<Car> Edit(string Id, [FromBody] Car car)
        {
            try
            {
                Car foundCar = FakeDb.Cars.Find(c => c.Id == Id);
                return Ok(foundCar = car);
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
                Car foundCar = FakeDb.Cars.Find(c => c.Id == Id);
                return Ok(FakeDb.Cars.Remove(foundCar));
            }
            catch (System.Exception err)
            {
                return BadRequest(err);
            }
        }
    }
}