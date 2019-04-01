using Microsoft.EntityFrameworkCore;
using SimelERP.Persistence.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimelERP.Persistence
{
  public  class SimelERPDbContextFactory : DesignTimeDbContextFactoryBase<SimelERPDbContext>
    {
        protected override SimelERPDbContext CreateNewInstance(DbContextOptions<SimelERPDbContext> options)
        {
            return new SimelERPDbContext(options);
        }
    }
}
