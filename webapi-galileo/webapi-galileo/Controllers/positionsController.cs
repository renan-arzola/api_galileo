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
using webapi_galileo;

namespace webapi_galileo.Controllers
{
    public class positionsController : ApiController
    {
        private galileo_dbEntities db = new galileo_dbEntities();

        // GET: api/positions
        public IQueryable<GAL_1680> GetGAL_1680()
        {
            return db.GAL_1680;
        }

        // GET: api/positions/5
        [ResponseType(typeof(GAL_1680))]
        public async Task<IHttpActionResult> GetGAL_1680(long id)
        {
            GAL_1680 gAL_1680 = await db.GAL_1680.FindAsync(id);
            if (gAL_1680 == null)
            {
                return NotFound();
            }

            return Ok(gAL_1680);
        }

        // PUT: api/positions/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutGAL_1680(long id, GAL_1680 gAL_1680)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != gAL_1680.cod_event)
            {
                return BadRequest();
            }

            db.Entry(gAL_1680).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GAL_1680Exists(id))
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

        // POST: api/positions
        [ResponseType(typeof(GAL_1680))]
        public async Task<IHttpActionResult> PostGAL_1680(GAL_1680 gAL_1680)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.GAL_1680.Add(gAL_1680);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = gAL_1680.cod_event }, gAL_1680);
        }

        // DELETE: api/positions/5
        [ResponseType(typeof(GAL_1680))]
        public async Task<IHttpActionResult> DeleteGAL_1680(long id)
        {
            GAL_1680 gAL_1680 = await db.GAL_1680.FindAsync(id);
            if (gAL_1680 == null)
            {
                return NotFound();
            }

            db.GAL_1680.Remove(gAL_1680);
            await db.SaveChangesAsync();

            return Ok(gAL_1680);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool GAL_1680Exists(long id)
        {
            return db.GAL_1680.Count(e => e.cod_event == id) > 0;
        }
    }
}