using ElegantArchitecture.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ElegantArchitecture.Infrastructure.Data
{
    public class ElegantContext : DbContext
    {
        public DbSet<DashboardSummary> DashboardSummary { get; set; }
    }
}
