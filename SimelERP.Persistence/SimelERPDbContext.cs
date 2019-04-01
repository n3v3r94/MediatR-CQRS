using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SimerERP.Domain.Entities;

namespace SimelERP.Persistence
{


    public class SimelERPDbContext : IdentityDbContext
    {


        public SimelERPDbContext(DbContextOptions<SimelERPDbContext> options)
           : base(options)
        {
        }

        public DbSet<TestERP> TestERPs { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(typeof(SimelERPDbContext).Assembly);
            base.OnModelCreating(builder);
        }
    }
}
