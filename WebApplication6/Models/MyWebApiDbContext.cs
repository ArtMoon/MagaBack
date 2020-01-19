using Microsoft.EntityFrameworkCore;

namespace DIMON_APP.Models
{
    public class MyWebApiDbContext: DbContext
    {

        public MyWebApiDbContext(DbContextOptions<MyWebApiDbContext> options) 
            : base(options){}

       /* protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Sensor_vals>().Property(f => f.Value_id).
        }*/
        public DbSet<User> Users { get; set; }
        public DbSet<SensorInfo> sensorInfo{get;set;}
        public DbSet<Apparatus> Apparatus { get; set; }
        public DbSet<Sensor_vals> Sensor_Val { get; set; }
    }
}
