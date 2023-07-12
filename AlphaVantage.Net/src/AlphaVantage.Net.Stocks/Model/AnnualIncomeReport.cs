﻿using System;

namespace AlphaVantage.Net.Stocks.Model
{
    public class AnnualIncomeReport
    {
        public DateTime FiscalDateEnding { get; set; }
        public string? ReportedCurrency { get; set; }
        public long GrossProfit { get; set; }
        public long TotalRevenue { get; set; }
        public long CostOfRevenue { get; set; }
        public long CostofGoodsAndServicesSold { get; set; }
        public long OperatingIncome { get; set; }
        public long SellingGeneralAndAdministrative { get; set; }
        public long ResearchAndDevelopment { get; set; }
        public long OperatingExpenses { get; set; }
        public long InvestmentIncomeNet { get; set; }
        public long NetInterestIncome { get; set; }
        public long InterestIncome { get; set; }
        public long InterestExpense { get; set; }
        public long NonInterestIncome { get; set; }
        public long OtherNonOperatingIncome { get; set; }
        public long Depreciation { get; set; }
        public long DepreciationAndAmortization { get; set; }
        public long IncomeBeforeTax { get; set; }
        public long IncomeTaxExpense { get; set; }
        public long InterestAndDebtExpense { get; set; }
        public long NetIncomeFromContinuingOperations { get; set; }
        public long ComprehensiveIncomeNetOfTax { get; set; }
        public long EBIT { get; set; }
        public long EBITDA { get; set; }
        public long NetIncome { get; set; }
    }
}