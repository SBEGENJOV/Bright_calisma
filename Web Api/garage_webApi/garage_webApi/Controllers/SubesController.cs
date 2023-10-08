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
using garage_webApi.Models;

namespace garage_webApi.Controllers
{
    public class SubesController : ApiController
    {
        private GarageEntities1 db = new GarageEntities1();

        // GET: api/Subes
        public IQueryable<Sube> GetSubes()
        {
            return db.Subes;
        }

        // GET: api/Subes/5
        [ResponseType(typeof(Sube))]
        public async Task<IHttpActionResult> GetSube(int id)
        {
            Sube sube = await db.Subes.FindAsync(id);
            if (sube == null)
            {
                return NotFound();
            }

            return Ok(sube);
        }

        // PUT: api/Subes/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutSube(int id, Sube sube)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != sube.SubeNo)
            {
                return BadRequest();
            }

            db.Entry(sube).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SubeExists(id))
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

        // POST: api/Subes
        [ResponseType(typeof(Sube))]
        public async Task<IHttpActionResult> PostSube(Sube sube)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Subes.Add(sube);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = sube.SubeNo }, sube);
        }

        // DELETE: api/Subes/5
        [ResponseType(typeof(Sube))]
        public async Task<IHttpActionResult> DeleteSube(int id)
        {
            Sube sube = await db.Subes.FindAsync(id);
            if (sube == null)
            {
                return NotFound();
            }

            db.Subes.Remove(sube);
            await db.SaveChangesAsync();

            return Ok(sube);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool SubeExists(int id)
        {
            return db.Subes.Count(e => e.SubeNo == id) > 0;
        }
    }
}