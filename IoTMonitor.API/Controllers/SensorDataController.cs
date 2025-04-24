using IoTMonitor.API.Data;
using IoTMonitor.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace IoTMonitor.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SensorDataController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public SensorDataController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<SensorData>>> GetSensorData()
        {
            return await _context.SensorData.Include(s => s.Device).ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<SensorData>> PostSensorData(SensorData data)
        {
            _context.SensorData.Add(data);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetSensorData), new { id = data.Id }, data);
        }
    }
}
