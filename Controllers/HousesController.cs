using System.Collections.Generic;
using gregslist.Models;
using Microsoft.AspNetCore.Mvc;
using gregslist.db;

namespace gregslist.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class HousesController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<House>> Get()
        {
            try
            {
                return Ok(FakeDb.Houses);
            }
            catch (System.Exception err)
            {
                return BadRequest(err);
            }
        }

        [HttpPost]
        public ActionResult<House> Create([FromBody] House house)
        {
            try
            {
                FakeDb.Houses.Add(house);
                return Ok(house);
            }
            catch (System.Exception err)
            {
                return BadRequest(err);
            }
        }

        [HttpGet("{Id}")]
        public ActionResult<House> GetById(string Id)
        {
            try
            {
                House foundHouse = FakeDb.Houses.Find(h => h.Id == Id);
                return Ok(foundHouse);
            }
            catch (System.Exception err)
            {
                return BadRequest(err);
            }
        }

        [HttpPut("{Id}")]
        public ActionResult<House> Edit(string Id, [FromBody] House house)
        {
            try
            {
                House foundHouse = FakeDb.Houses.Find(h => h.Id == Id);
                return Ok(foundHouse = house);
            }
            catch (System.Exception err)
            {
                return BadRequest(err);
            }
        }

        [HttpDelete("{Id}")]
        public ActionResult<House> Delete(string Id)
        {
            try
            {
                House foundHouse = FakeDb.Houses.Find(h => h.Id == Id);
                return Ok(FakeDb.Houses.Remove(foundHouse));
            }
            catch (System.Exception err)
            {
                return BadRequest(err);
            }
        }
    }
}