﻿using System;

namespace AlphaVantage.Net.Stocks.Model
{
    public class AnnualReport
    {
        public DateTime FiscalDateEnding { get; set; }
        public string? ReportedCurrency { get; set; }
        public long TotalAssets { get; set; }
        public long TotalCurrentAssets { get; set; }
        public long CashAndCashEquivalentsAtCarryingValue { get; set; }
        public long CashAndShortTermInvestments { get; set; }
        public long Inventory { get; set; }
        public long CurrentNetReceivables { get; set; }
        public long TotalNonCurrentAssets { get; set; }
        public long PropertyPlantEquipment { get; set; }
        public long AccumulatedDepreciationAmortizationPPE { get; set; }
        public long IntangibleAssets { get; set; }
        public long IntangibleAssetsExcludingGoodwill { get; set; }
        public long Goodwill { get; set; }
        public long Investments { get; set; }
        public long LongTermInvestments { get; set; }
        public long ShortTermInvestments { get; set; }
        public long OtherCurrentAssets { get; set; }
        public long OtherNonCurrentAssets { get; set; }
        public long TotalLiabilities { get; set; }
        public long TotalCurrentLiabilities { get; set; }
        public long CurrentAccountsPayable { get; set; }
        public long DeferredRevenue { get; set; }
        public long CurrentDebt { get; set; }
        public long ShortTermDebt { get; set; }
        public long TotalNonCurrentLiabilities { get; set; }
        public long CapitalLeaseObligations { get; set; }
        public long LongTermDebt { get; set; }
        public long CurrentLongTermDebt { get; set; }
        public long LongTermDebtNoncurrent { get; set; }
        public long ShortLongTermDebtTotal { get; set; }
        public long OtherCurrentLiabilities { get; set; }
        public long OtherNonCurrentLiabilities { get; set; }
        public long TotalShareholderEquity { get; set; }
        public long TreasuryStock { get; set; }
        public long RetainedEarnings { get; set; }
        public long CommonStock { get; set; }
        public long CommonStockSharesOutstanding { get; set; }
    }
}