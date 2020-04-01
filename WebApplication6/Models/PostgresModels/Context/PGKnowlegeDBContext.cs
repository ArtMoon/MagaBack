using Microsoft.EntityFrameworkCore;

namespace DIMON_APP.Models.PG
{
    public class PGKnowledgeDBContext : DbContext
    {

        public DbSet<Problem> dm_problem{get;set;}
        public DbSet<Reason> dm_reason{get;set;}
        public DbSet<Solution> dm_solution{get;set;}



        public PGKnowledgeDBContext(DbContextOptions<PGKnowledgeDBContext> options)
            :base(options){}

          protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            
            modelBuilder.Entity<Problem>()
                .HasMany(a => a.reasons)
                .WithOne(b => b.problem)
                .HasForeignKey(x => x.pr_id);

            modelBuilder.Entity<Reason>()
                .HasMany(a => a.solutions)
                .WithOne(b => b.reason)
                .HasForeignKey(x => x.rs_id);
        }

    }
}