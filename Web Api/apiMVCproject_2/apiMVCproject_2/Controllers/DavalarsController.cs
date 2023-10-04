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
using apiMVCproject_2.Models;

namespace apiMVCproject_2.Controllers
{
    public class DavalarsController : ApiController
    {
        private sbHukukEntities1 db = new sbHukukEntities1();

        // GET: api/Davalars
        public IQueryable<Davalar> GetDavalars()
        {
            return db.Davalars;
        }

        // GET: api/Davalars/5
        [ResponseType(typeof(Davalar))]
        public async Task<IHttpActionResult> GetDavalar(int id)
        {
            Davalar davalar = await db.Davalars.FindAsync(id);
            if (davalar == null)
            {
                return NotFound();
            }

            return Ok(davalar);
        }

        // PUT: api/Davalars/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutDavalar(int id, Davalar davalar)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != davalar.DavaNo)
            {
                return BadRequest();
            }

            db.Entry(davalar).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DavalarExists(id))
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

        // POST: api/Davalars
        [ResponseType(typeof(Davalar))]
        public async Task<IHttpActionResult> PostDavalar(Davalar davalar)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Davalars.Add(davalar);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = davalar.DavaNo }, davalar);
        }

        // DELETE: api/Davalars/5
        [ResponseType(typeof(Davalar))]
        public async Task<IHttpActionResult> DeleteDavalar(int id)
        {
            Davalar davalar = await db.Davalars.FindAsync(id);
            if (davalar == null)
            {
                return NotFound();
            }

            db.Davalars.Remove(davalar);
            await db.SaveChangesAsync();

            return Ok(davalar);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool DavalarExists(int id)
        {
            return db.Davalars.Count(e => e.DavaNo == id) > 0;
        }
    }
}