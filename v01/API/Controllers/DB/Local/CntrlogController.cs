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
    public class CntrlogController : ControllerBase
    {
        private readonly LocalContext _context;

        public CntrlogController(LocalContext context)
        {
            _context = context;
        }

        // GET: api/Cntrlog
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Cntrlog>>> GetCntrlog()
        {
            return await _context.Cntrlog.ToListAsync();
        }

        // GET: api/Cntrlog/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Cntrlog>> GetCntrlog(long id)
        {
            var cntrlog = await _context.Cntrlog.FindAsync(id);

            if (cntrlog == null)
            {
                return NotFound();
            }

            return cntrlog;
        }

        // PUT: api/Cntrlog/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCntrlog(long id, Cntrlog cntrlog)
        {
            if (id != cntrlog.Id)
            {
                return BadRequest();
            }

            _context.Entry(cntrlog).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CntrlogExists(id))
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

        // POST: api/Cntrlog
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Cntrlog>> PostCntrlog(Cntrlog cntrlog)
        {
            _context.Cntrlog.Add(cntrlog);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCntrlog", new { id = cntrlog.Id }, cntrlog);
        }

        // DELETE: api/Cntrlog/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Cntrlog>> DeleteCntrlog(long id)
        {
            var cntrlog = await _context.Cntrlog.FindAsync(id);
            if (cntrlog == null)
            {
                return NotFound();
            }

            _context.Cntrlog.Remove(cntrlog);
            await _context.SaveChangesAsync();

            return cntrlog;
        }

        private bool CntrlogExists(long id)
        {
            return _context.Cntrlog.Any(e => e.Id == id);
        }
    }
}
