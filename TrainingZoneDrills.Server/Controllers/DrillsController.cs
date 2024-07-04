using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TrainingZoneDrills.Server.Context;

namespace TrainingZoneDrills.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DrillsController : ControllerBase
    {
        private readonly TrainingZoneContext _context;

        public DrillsController(TrainingZoneContext context)
        {
            _context = context;
        }

        // GET: api/drills
        // This method returns all drills
        [HttpGet]
        public async Task<IActionResult> GetAllDrills()
        {
            var drills = await _context.Drills.ToListAsync();
            return Ok(drills);
        }

        // GET: api/drills/id
        // This method returns a specific drill by its ID
        [HttpGet("{id}")]
        public async Task<IActionResult> GetDrill(int id)
        {
            var drill = await _context.Drills.FindAsync(id);

            if (drill == null)
            {
                return NotFound();
            }

            return Ok(drill);
        }
    }
}
