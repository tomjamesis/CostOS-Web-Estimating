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
    public class ExtdatasourceController : ControllerBase
    {
        private readonly LocalContext _context;

        public ExtdatasourceController(LocalContext context)
        {
            _context = context;
        }

        // GET: api/Extdatasource
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ExtDatasource>>> GetExtdatasource()
        {
            return await _context.ExtDatasource.ToListAsync();
        }

        // GET: api/Extdatasource/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ExtDatasource>> GetExtdatasource(long id)
        {
            var extdatasource = await _context.ExtDatasource.FindAsync(id);

            if (extdatasource == null)
            {
                return NotFound();
            }

            return extdatasource;
        }

        // PUT: api/Extdatasource/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutExtdatasource(long id, ExtDatasource extdatasource)
        {
            if (id != extdatasource.Datasourceid)
            {
                return BadRequest();
            }

            _context.Entry(extdatasource).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ExtdatasourceExists(id))
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

        // POST: api/Extdatasource
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<ExtDatasource>> PostExtdatasource(ExtDatasource extdatasource)
        {
            _context.ExtDatasource.Add(extdatasource);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetExtdatasource", new { id = extdatasource.Datasourceid }, extdatasource);
        }

        // DELETE: api/Extdatasource/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ExtDatasource>> DeleteExtdatasource(long id)
        {
            var extdatasource = await _context.ExtDatasource.FindAsync(id);
            if (extdatasource == null)
            {
                return NotFound();
            }

            _context.ExtDatasource.Remove(extdatasource);
            await _context.SaveChangesAsync();

            return extdatasource;
        }

        private bool ExtdatasourceExists(long id)
        {
            return _context.ExtDatasource.Any(e => e.Datasourceid == id);
        }
    }
}
