// using IoTMonitor.API.Models;
using IoTMonitor.API.Models;
using Microsoft.EntityFrameworkCore;

namespace IoTMonitor.API.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Device> Devices { get; set; }
        public DbSet<SensorData> SensorData { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Device has many SensorData
            modelBuilder.Entity<Device>()
                .HasMany(d => d.SensorReadings)
                .WithOne(s => s.Device)
                .HasForeignKey(s => s.DeviceId);
        }
    }
}
