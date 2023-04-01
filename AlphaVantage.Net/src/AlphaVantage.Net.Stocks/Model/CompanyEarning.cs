using System.Collections.Generic;

namespace AlphaVantage.Net.Stocks.Model
{
    /// <summary>
    /// Company Earnings of the recent years
    /// </summary>
    public class CompanyEarning
    {
        public CompanyEarning(List<AnnualEarning> annualEarnings)
        {
            AnnualEarnings = annualEarnings;
        }

        public string? Symbol { get; set; }
        public List<AnnualEarning> AnnualEarnings { get; set; }
    }

    public class AnnualEarning
    {
        public string? FiscalDateEnding { get; set; }
        public string? ReportedEPS { get; set; }
    }
}