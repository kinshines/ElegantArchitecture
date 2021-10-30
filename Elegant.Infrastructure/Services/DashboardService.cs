using Elegant.Core.Entities;
using Elegant.Infrastructure.Data;
using NAutowired.Core.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Elegant.Infrastructure.Services
{
    [Service]
    public class DashboardService
    {
        [Autowired]
        ElegantContext context;

        public DashboardSummary GetSummary()
        {
            return context.DashboardSummary.FirstOrDefault();
        }
    }
}
