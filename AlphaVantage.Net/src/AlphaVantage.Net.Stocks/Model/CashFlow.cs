using System.Collections.Generic;

namespace AlphaVantage.Net.Stocks.Model
{
    public class CashFlow
    {
        public CashFlow(List<AnnualCashflowReport> annualReports)
        {
            AnnualReports = annualReports;
        }

        public string? Symbol { get; set; }
        public List<AnnualCashflowReport> AnnualReports { get; set; }
    }
}