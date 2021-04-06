using System.Collections.Generic;
using gregslist.db;
using gregslist.Models;
using Microsoft.AspNetCore.Mvc;

namespace gregslist.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class JobsController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<Job>> Get()
        {
            try
            {
                return Ok(FakeDb.Jobs);
            }
            catch (System.Exception err)
            {
                return BadRequest(err);
            }
        }

        [HttpPost]
        public ActionResult<Job> Create([FromBody] Job job)
        {
            try
            {
                FakeDb.Jobs.Add(job);
                return Ok(job);
            }
            catch (System.Exception err)
            {
                return BadRequest(err);
            }
        }

        [HttpGet("{Id}")]
        public ActionResult<Job> GetById(string Id)
        {
            try
            {
                Job foundJob = FakeDb.Jobs.Find(j => j.Id == Id);
                return Ok(foundJob);
            }
            catch (System.Exception err)
            {
                return BadRequest(err);
            }
        }

        [HttpPost("{Id}")]
        public ActionResult<Job> Edit(string Id, [FromBody] Job job)
        {
            try
            {
                Job foundJob = FakeDb.Jobs.Find(j => j.Id == Id);
                return Ok(foundJob = job);
            }
            catch (System.Exception err)
            {
                return BadRequest(err);
            }
        }

        [HttpDelete("{Id}")]
        public ActionResult<Job> Delete(string Id)
        {
            try
            {
                Job foundJob = FakeDb.Jobs.Find(h => h.Id == Id);
                return Ok(FakeDb.Jobs.Remove(foundJob));
            }
            catch (System.Exception err)
            {
                return BadRequest(err);
            }
        }
    }
}