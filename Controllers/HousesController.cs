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
    }
}