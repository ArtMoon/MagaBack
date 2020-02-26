using Microsoft.EntityFrameworkCore;

namespace DIMON_APP.Models
{
    public class MyWebApiDbContext: DbContext
    {

        public MyWebApiDbContext(DbContextOptions<MyWebApiDbContext> options) 
            : base(options){}

        public DbSet<User> Users { get; set; }
        public DbSet<SensorInfo> sensorInfo{get;set;}
        public DbSet<Apparatus> Apparatus { get; set; }
        public DbSet<Sensor_vals> Sensor_Val { get; set; }
    }
}
