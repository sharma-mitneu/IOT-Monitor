using Microsoft.EntityFrameworkCore;
//using IoTMonitor.API.Models;

namespace IoTMonitor.API.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<Device> Devices { get; set; }
        public DbSet<SensorData> SensorData { get; set; }
    }
}
