using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Models.DB.Local;

namespace API.Controllers.DB.Local
{
    [Route("api/[controller]")]
    [ApiController]
    public class BcGroupelemController : ControllerBase
    {
        private readonly localContext _context;

        public BcGroupelemController(localContext context)
        {
            _context = context;
        }

        // GET: api/BcGroupelem
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BcGroupelem>>> GetBcGroupelem()
        {
            return await _context.BcGroupelem.ToListAsync();
        }

        // GET: api/BcGroupelem/5
        [HttpGet("{id}")]
        public async Task<ActionResult<BcGroupelem>> GetBcGroupelem(long id)
        {
            var bcGroupelem = await _context.BcGroupelem.FindAsync(id);

            if (bcGroupelem == null)
            {
                return NotFound();
            }

            return bcGroupelem;
        }

        // PUT: api/BcGroupelem/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBcGroupelem(long id, BcGroupelem bcGroupelem)
        {
            if (id != bcGroupelem.Id)
            {
                return BadRequest();
            }

            _context.Entry(bcGroupelem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BcGroupelemExists(id))
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

        // POST: api/BcGroupelem
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<BcGroupelem>> PostBcGroupelem(BcGroupelem bcGroupelem)
        {
            _context.BcGroupelem.Add(bcGroupelem);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBcGroupelem", new { id = bcGroupelem.Id }, bcGroupelem);
        }

        // DELETE: api/BcGroupelem/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<BcGroupelem>> DeleteBcGroupelem(long id)
        {
            var bcGroupelem = await _context.BcGroupelem.FindAsync(id);
            if (bcGroupelem == null)
            {
                return NotFound();
            }

            _context.BcGroupelem.Remove(bcGroupelem);
            await _context.SaveChangesAsync();

            return bcGroupelem;
        }

        private bool BcGroupelemExists(long id)
        {
            return _context.BcGroupelem.Any(e => e.Id == id);
        }
    }
}
