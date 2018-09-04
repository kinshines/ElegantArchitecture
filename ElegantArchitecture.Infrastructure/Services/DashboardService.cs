using ElegantArchitecture.Core.Entities;
using ElegantArchitecture.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ElegantArchitecture.Infrastructure.Services
{
    public class DashboardService
    {
        protected ElegantContext context;
        public DashboardService(ElegantContext context)
        {
            this.context = context;
        }

        public DashboardSummary GetSummary()
        {
            return context.DashboardSummary.FirstOrDefault();
        }
    }
}
