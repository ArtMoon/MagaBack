using System;
using Microsoft.EntityFrameworkCore;

namespace DIMON_APP.Models.PG
{
    public class PostgresDBContext : DbContext
    {
        public DbSet<Apparatus2SensLink> dm_apparatus_2_sens_link{get;set;}
        public DbSet<ApparatusInfo> dm_apparatus_info{get;set;}
        public DbSet<Sensor> dm_sensors{get;set;}
        public DbSet<SensorVal> dm_sensor_vals{get;set;}
        public DbSet<User> dm_users{get;set;}
        public DbSet<Apparatus> dm_apparatuses{get;set;}
        public DbSet<Alarm> dm_alarms{get;set;}

        public PostgresDBContext(DbContextOptions<PostgresDBContext> options)
            :base(options){}

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            
            modelBuilder.Entity<Apparatus>()
                .HasMany(a => a.app_link)
                .WithOne(b => b.Apparatus)
                .HasForeignKey(x => x.ap_id);

            modelBuilder.Entity<Sensor>()
                .HasOne(a => a.app_link)
                .WithOne(b => b.Sensor)
                .HasForeignKey<Apparatus2SensLink>(x => x.sens_id);

            modelBuilder.Entity<Sensor>()
                .HasMany(a => a.alarms)
                .WithOne(b => b.sensor)
                .HasForeignKey(x => x.sens_id);

            modelBuilder.Entity<Apparatus>()
                .HasMany(a => a.alarms)
                .WithOne(x => x.apparatus)
                .HasForeignKey(x => x.ap_id);
        }
    }
}