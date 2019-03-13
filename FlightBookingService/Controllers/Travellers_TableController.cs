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
using FlightBookingService.Models;

namespace FlightBookingService.Controllers
{
    public class Travellers_TableController : ApiController
    {
        private BookMyFlightEntities db = new BookMyFlightEntities();

        // GET: api/Travellers_Table
        public IQueryable<Travellers_Table> GetTravellers_Table()
        {
            return db.Travellers_Table;
        }

        // GET: api/Travellers_Table/5
        [ResponseType(typeof(Travellers_Table))]
        public async Task<IHttpActionResult> GetTravellers_Table(long id)
        {
            Travellers_Table travellers_Table = await db.Travellers_Table.FindAsync(id);
            if (travellers_Table == null)
            {
                return NotFound();
            }

            return Ok(travellers_Table);
        }

        // PUT: api/Travellers_Table/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutTravellers_Table(long id, Travellers_Table travellers_Table)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != travellers_Table.Id)
            {
                return BadRequest();
            }

            db.Entry(travellers_Table).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Travellers_TableExists(id))
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

        // POST: api/Travellers_Table
        [ResponseType(typeof(Travellers_Table))]
        public async Task<IHttpActionResult> PostTravellers_Table(Travellers_Table travellers_Table )
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Travellers_Table.Add(travellers_Table);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = travellers_Table.Id }, travellers_Table);
        }

        // DELETE: api/Travellers_Table/5
        [ResponseType(typeof(Travellers_Table))]
        public async Task<IHttpActionResult> DeleteTravellers_Table(long id)
        {
            Travellers_Table travellers_Table = await db.Travellers_Table.FindAsync(id);
            if (travellers_Table == null)
            {
                return NotFound();
            }

            db.Travellers_Table.Remove(travellers_Table);
            await db.SaveChangesAsync();

            return Ok(travellers_Table);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool Travellers_TableExists(long id)
        {
            return db.Travellers_Table.Count(e => e.Id == id) > 0;
        }
    }
}