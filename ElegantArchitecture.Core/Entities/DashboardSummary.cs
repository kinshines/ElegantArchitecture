using System;
using System.Collections.Generic;
using System.Text;

namespace Elegant.Core.Entities
{
    public class DashboardSummary
    {
        public long Id { get; set; }
        public int Profit { get; set; }
        public int ProfitProgress { get; set; }
        public int Feedback { get; set; }
        public int FeedbackChange { get; set; }
        public int Order { get; set; }
        public int OrderGrow { get; set; }
        public int User { get; set; }
        public int UserChange { get; set; }
        public int Popularity { get; set; }
        public int Balance { get; set; }
        public int Weekly { get; set; }
        public int Biggest { get; set; }
        public int Monthly { get; set; }
    }
}
