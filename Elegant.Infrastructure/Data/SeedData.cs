using Elegant.Core.Entities;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Elegant.Infrastructure.Data
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            var dashboardSummary = new DashboardSummary()
            {
                Profit = 7800,
                ProfitProgress = 76,
                Feedback = 1349,
                FeedbackChange = 85,
                Order = 567,
                OrderGrow = 45,
                User = 276,
                UserChange = 57,
                Popularity = 89,
                Balance = 7644,
                Weekly = 1293,
                Biggest = 815,
                Monthly = 5071
            };
            var context = serviceProvider.GetRequiredService<ElegantContext>();
            context.DashboardSummary.Add(dashboardSummary);
            context.SaveChanges();
        }
    }
}
