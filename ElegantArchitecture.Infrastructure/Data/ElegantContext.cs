using ElegantArchitecture.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ElegantArchitecture.Infrastructure.Data
{
    public class ElegantContext : DbContext
    {
        public ElegantContext(DbContextOptions<ElegantContext> options)
            :base(options)
        {
        }
        public DbSet<DashboardSummary> DashboardSummary { get; set; }
    }
}
