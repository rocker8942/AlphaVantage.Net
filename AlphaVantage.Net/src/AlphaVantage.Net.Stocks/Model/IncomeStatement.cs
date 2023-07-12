using System.Collections.Generic;

namespace AlphaVantage.Net.Stocks.Model
{
    public class IncomeStatement
    {
        public IncomeStatement(List<AnnualIncomeReport> annualReports)
        {
            AnnualReports = annualReports;
        }

        public string? Symbol { get; set; }
        public List<AnnualIncomeReport> AnnualReports { get; set; }
    }
}