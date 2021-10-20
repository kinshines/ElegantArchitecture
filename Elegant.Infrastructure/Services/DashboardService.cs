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
            var summary = new DashboardSummary()
            {
                Profit = 7800,
                ProfitProgress = 76,
                Feedback=1349,
                FeedbackChange=85,
                Order=567,
                OrderGrow=45,
                User=276,
                UserChange=57,
            };            
            return summary;
            //return context.DashboardSummary.FirstOrDefault();
        }
    }
}
