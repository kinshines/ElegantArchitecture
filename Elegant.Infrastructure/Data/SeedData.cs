using Elegant.Core.Entities;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Elegant.Infrastructure.Data
{
    public static class SeedData
    {
        public static void EnsurePopulated(IServiceProvider serviceProvider)
        {
            var context = serviceProvider.GetRequiredService<ElegantContext>();
            PopDashboard(context);
            context.SaveChanges();
        }

        private static void PopDashboard(ElegantContext context)
        {
            var dashboardSummary = new DashboardSummary()
            {
                Profit = 7800,
                ProfitProgress = 76,
                Feedback = 1349,
                FeedbackChange = 85,
                Order = 549,
                OrderGrow = 45,
                User = 276,
                UserChange = 57,
                Popularity = 89,
                Balance = 7644,
                Weekly = 1293,
                Biggest = 815,
                Monthly = 5071
            };
            if (context.DashboardSummary.Any())
            {
                return;
            }
            context.DashboardSummary.Add(dashboardSummary);
        }
    }
}
