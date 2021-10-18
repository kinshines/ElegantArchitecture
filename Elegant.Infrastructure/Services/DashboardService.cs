using Elegant.Core.Entities;
using Elegant.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Elegant.Infrastructure.Services
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
            return new DashboardSummary();
            return context.DashboardSummary.FirstOrDefault();
        }
    }
}
