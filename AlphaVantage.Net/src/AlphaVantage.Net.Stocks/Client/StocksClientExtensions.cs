using System.Collections.Generic;
using System.Threading.Tasks;
using AlphaVantage.Net.Common;
using AlphaVantage.Net.Common.Intervals;
using AlphaVantage.Net.Common.Parsing;
using AlphaVantage.Net.Common.Size;
using AlphaVantage.Net.Stocks.Model;
using AlphaVantage.Net.Stocks.Parsing;

namespace AlphaVantage.Net.Stocks.Client
{
    public static class StocksClientExtensions
    {
        private static readonly WrappedValueParser<GlobalQuote> GlobalQuoteParser = 
            new WrappedValueParser<GlobalQuote>("Global Quote");
        
        private static readonly WrappedValueParser<List<SymbolSearchMatch>> SearchResultParser = 
            new WrappedValueParser<List<SymbolSearchMatch>>("bestMatches");
        
        
        /// <summary>
        /// Returns stocks time series for requested symbol 
        /// </summary>
        /// <param name="stocksClient"></param>
        /// <param name="symbol"></param>
        /// <param name="interval"></param>
        /// <param name="size"></param>
        /// <param name="isAdjusted"></param>
        /// <returns></returns>
        public static async Task<StockTimeSeries> GetTimeSeriesAsync(this StocksClient stocksClient, 
            string symbol, 
            Interval interval,
            OutputSize size = OutputSize.Compact,
            bool isAdjusted = false)
        {
            var parser = new StocksTimeSeriesParser(interval, isAdjusted);
            
            var query = new Dictionary<string, string>()
            {
                {ApiQueryConstants.SymbolQueryVar, symbol},
                {ApiQueryConstants.OutputSizeQueryVar, size.ConvertToQueryString()}
            };

            var function = interval.ConvertToApiFunction(isAdjusted);
            if (function == ApiFunction.TIME_SERIES_INTRADAY)
            {
                query.Add(ApiQueryConstants.IntervalQueryVar, interval.ConvertToQueryString());
            }
            
            return await stocksClient.RequestApiAsync(parser, function, query);
        }

        /// <summary>
        /// Returns the price and volume information for a symbol
        /// </summary>
        /// <param name="stocksClient"></param>
        /// <param name="symbol"></param>
        /// <remarks>
        /// function=GLOBAL_QUOTE
        /// </remarks>
        public static async Task<GlobalQuote?> GetGlobalQuoteAsync(this StocksClient stocksClient, string symbol)
        {
            var query = new Dictionary<string, string>(){{ApiQueryConstants.SymbolQueryVar, symbol}};
            return await stocksClient.RequestApiAsync(GlobalQuoteParser, ApiFunction.GLOBAL_QUOTE, query);
        }
        
        /// <summary>
        /// Returns the best-matching symbols and market information based on keywords
        /// </summary>
        /// <param name="stocksClient"></param>
        /// <param name="keyWords"></param>
        /// <remarks>
        /// function=SYMBOL_SEARCH
        /// </remarks>
        public static async Task<ICollection<SymbolSearchMatch>> SearchSymbolAsync(this StocksClient stocksClient, string keyWords)
        {
            var query = new Dictionary<string, string>(){{"keywords", keyWords}};
            return await stocksClient.RequestApiAsync(SearchResultParser, ApiFunction.SYMBOL_SEARCH, query);
        }

        /// <summary>
        /// Returns company overview for a symbol
        /// </summary>
        /// <param name="stocksClient"></param>
        /// <param name="symbol"></param>
        /// <returns></returns>
        public static async Task<Company?> GetCompanyOverview(this StocksClient stocksClient, string symbol)
        {
            // todo: need to create a parser
            var parser = new AlphaVantageJsonParser<Company?>();

            var query = new Dictionary<string, string>()
            {
                { ApiQueryConstants.SymbolQueryVar, symbol }
            };

            return await stocksClient.RequestApiAsync(parser, ApiFunction.OVERVIEW, query);
        }

        /// <summary>
        /// Returns company earning for a symbol
        /// </summary>
        /// <param name="stocksClient"></param>
        /// <param name="symbol"></param>
        /// <returns></returns>
        public static async Task<CompanyEarning?> GetEarnings(this StocksClient stocksClient, string symbol)
        {
            var parser = new AlphaVantageJsonParser<CompanyEarning?>();

            var query = new Dictionary<string, string>()
            {
                { ApiQueryConstants.SymbolQueryVar, symbol }
            };

            return await stocksClient.RequestApiAsync(parser, ApiFunction.EARNINGS, query);
        }

        /// <summary>
        /// Returns company earning for a symbol
        /// </summary>
        /// <param name="stocksClient"></param>
        /// <param name="symbol"></param>
        /// <returns></returns>
        public static async Task<BalanceSheet?> GetBalanceSheet(this StocksClient stocksClient, string symbol)
        {
            var parser = new AlphaVantageJsonParser<BalanceSheet?>();

            var query = new Dictionary<string, string>()
            {
                { ApiQueryConstants.SymbolQueryVar, symbol }
            };

            return await stocksClient.RequestApiAsync(parser, ApiFunction.BALANCE_SHEET, query);
        }

        /// <summary>
        /// Returns income statement
        /// </summary>
        /// <param name="stocksClient"></param>
        /// <param name="symbol"></param>
        /// <returns></returns>
        public static async Task<IncomeStatement?> GetIncomeStatement(this StocksClient stocksClient, string symbol)
        {
            var parser = new AlphaVantageJsonParser<IncomeStatement?>();

            var query = new Dictionary<string, string>()
            {
                { ApiQueryConstants.SymbolQueryVar, symbol }
            };

            return await stocksClient.RequestApiAsync(parser, ApiFunction.INCOME_STATEMENT, query);
        }

        /// <summary>
        /// Returns cashflow
        /// </summary>
        /// <param name="stocksClient"></param>
        /// <param name="symbol"></param>
        /// <returns></returns>
        public static async Task<CashFlow?> GetCashFlow(this StocksClient stocksClient, string symbol)
        {
            var parser = new AlphaVantageJsonParser<CashFlow?>();

            var query = new Dictionary<string, string>()
            {
                { ApiQueryConstants.SymbolQueryVar, symbol }
            };

            return await stocksClient.RequestApiAsync(parser, ApiFunction.CASH_FLOW, query);
        }
    }
}