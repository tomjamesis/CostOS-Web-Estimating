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
    public class WsdatamappingController : ControllerBase
    {
        private readonly LocalContext _context;

        public WsdatamappingController(LocalContext context)
        {
            _context = context;
        }

        // GET: api/Wsdatamapping
        [HttpGet]
        public async Task<ActionResult<IEnumerable<WsDataMapping>>> GetWsdatamapping()
        {
            return await _context.WsDataMapping.ToListAsync();
        }

        // GET: api/Wsdatamapping/5
        [HttpGet("{id}")]
        public async Task<ActionResult<WsDataMapping>> GetWsdatamapping(long id)
        {
            var wsdatamapping = await _context.WsDataMapping.FindAsync(id);

            if (wsdatamapping == null)
            {
                return NotFound();
            }

            return wsdatamapping;
        }

        // PUT: api/Wsdatamapping/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutWsdatamapping(long id, WsDataMapping wsdatamapping)
        {
            if (id != wsdatamapping.Id)
            {
                return BadRequest();
            }

            _context.Entry(wsdatamapping).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WsdatamappingExists(id))
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

        // POST: api/Wsdatamapping
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<WsDataMapping>> PostWsdatamapping(WsDataMapping wsdatamapping)
        {
            _context.WsDataMapping.Add(wsdatamapping);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetWsdatamapping", new { id = wsdatamapping.Id }, wsdatamapping);
        }

        // DELETE: api/Wsdatamapping/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<WsDataMapping>> DeleteWsdatamapping(long id)
        {
            var wsdatamapping = await _context.WsDataMapping.FindAsync(id);
            if (wsdatamapping == null)
            {
                return NotFound();
            }

            _context.WsDataMapping.Remove(wsdatamapping);
            await _context.SaveChangesAsync();

            return wsdatamapping;
        }

        private bool WsdatamappingExists(long id)
        {
            return _context.WsDataMapping.Any(e => e.Id == id);
        }
    }
}
