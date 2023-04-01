using System.Collections.Generic;

namespace AlphaVantage.Net.Stocks.Model
{
    public class BalanceSheet
    {
        public BalanceSheet(List<AnnualReport> annualReports)
        {
            AnnualReports = annualReports;
        }

        public string? Symbol { get; set; }
        public List<AnnualReport> AnnualReports { get; set; }
    }
}