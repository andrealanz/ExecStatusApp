using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using ExecStatusApp.Data;
using ExecStatusApp.Models;

namespace ExecStatusApp.Controllers
{
    public class ExecStatsController : ApiController
    {
        private ExecStatusAppContext db = new ExecStatusAppContext();

        // GET: api/ExecStats
        public IQueryable<ExecStats> GetExecStats()
        {
            return db.ExecStats;
        }

        // GET: api/ExecStats/5
        [ResponseType(typeof(ExecStats))]
        public async Task<IHttpActionResult> GetExecStats(string id)
        {
            ExecStats execStats = await db.ExecStats.FindAsync(id);
            if (execStats == null)
            {
                return NotFound();
            }

            return Ok(execStats);
        }

        // PUT: api/ExecStats/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutExecStats(string id, ExecStats execStats)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != execStats.Id)
            {
                return BadRequest();
            }

            db.Entry(execStats).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ExecStatsExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/ExecStats
        [ResponseType(typeof(ExecStats))]
        public async Task<IHttpActionResult> PostExecStats(ExecStats execStats)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.ExecStats.Add(execStats);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ExecStatsExists(execStats.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = execStats.Id }, execStats);
        }

        // DELETE: api/ExecStats/5
        [ResponseType(typeof(ExecStats))]
        public async Task<IHttpActionResult> DeleteExecStats(string id)
        {
            ExecStats execStats = await db.ExecStats.FindAsync(id);
            if (execStats == null)
            {
                return NotFound();
            }

            db.ExecStats.Remove(execStats);
            await db.SaveChangesAsync();

            return Ok(execStats);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ExecStatsExists(string id)
        {
            return db.ExecStats.Count(e => e.Id == id) > 0;
        }
    }
}