using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Models.DB.Local;

namespace ClientBlazor.Server.Controllers.Local
{
    [Route("api/[controller]")]
    [ApiController]
    public class TakeofftriangleController : ControllerBase
    {
        private readonly localContext _context;

        public TakeofftriangleController(localContext context)
        {
            _context = context;
        }

        // GET: api/Takeofftriangle
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Takeofftriangle>>> GetTakeofftriangle()
        {
            return await _context.Takeofftriangle.ToListAsync();
        }

        // GET: api/Takeofftriangle/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Takeofftriangle>> GetTakeofftriangle(long id)
        {
            var takeofftriangle = await _context.Takeofftriangle.FindAsync(id);

            if (takeofftriangle == null)
            {
                return NotFound();
            }

            return takeofftriangle;
        }

        // PUT: api/Takeofftriangle/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTakeofftriangle(long id, Takeofftriangle takeofftriangle)
        {
            if (id != takeofftriangle.Id)
            {
                return BadRequest();
            }

            _context.Entry(takeofftriangle).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TakeofftriangleExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Takeofftriangle
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Takeofftriangle>> PostTakeofftriangle(Takeofftriangle takeofftriangle)
        {
            _context.Takeofftriangle.Add(takeofftriangle);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTakeofftriangle", new { id = takeofftriangle.Id }, takeofftriangle);
        }

        // DELETE: api/Takeofftriangle/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Takeofftriangle>> DeleteTakeofftriangle(long id)
        {
            var takeofftriangle = await _context.Takeofftriangle.FindAsync(id);
            if (takeofftriangle == null)
            {
                return NotFound();
            }

            _context.Takeofftriangle.Remove(takeofftriangle);
            await _context.SaveChangesAsync();

            return takeofftriangle;
        }

        private bool TakeofftriangleExists(long id)
        {
            return _context.Takeofftriangle.Any(e => e.Id == id);
        }
    }
}
