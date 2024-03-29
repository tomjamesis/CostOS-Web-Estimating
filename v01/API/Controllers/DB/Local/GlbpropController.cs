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
    public class GlbpropController : ControllerBase
    {
        private readonly LocalContext _context;

        public GlbpropController(LocalContext context)
        {
            _context = context;
        }

        // GET: api/Glbprop
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GlbProp>>> GetGlbprop()
        {
            return await _context.GlbProp.ToListAsync();
        }

        // GET: api/Glbprop/5
        [HttpGet("{id}")]
        public async Task<ActionResult<GlbProp>> GetGlbprop(long id)
        {
            var glbprop = await _context.GlbProp.FindAsync(id);

            if (glbprop == null)
            {
                return NotFound();
            }

            return glbprop;
        }

        // PUT: api/Glbprop/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGlbprop(long id, GlbProp glbprop)
        {
            if (id != glbprop.Id)
            {
                return BadRequest();
            }

            _context.Entry(glbprop).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GlbpropExists(id))
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

        // POST: api/Glbprop
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<GlbProp>> PostGlbprop(GlbProp glbprop)
        {
            _context.GlbProp.Add(glbprop);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetGlbprop", new { id = glbprop.Id }, glbprop);
        }

        // DELETE: api/Glbprop/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<GlbProp>> DeleteGlbprop(long id)
        {
            var glbprop = await _context.GlbProp.FindAsync(id);
            if (glbprop == null)
            {
                return NotFound();
            }

            _context.GlbProp.Remove(glbprop);
            await _context.SaveChangesAsync();

            return glbprop;
        }

        private bool GlbpropExists(long id)
        {
            return _context.GlbProp.Any(e => e.Id == id);
        }
    }
}
