using System;
using AlphaVantage.Net.Common.Parsing;
using Newtonsoft.Json;

namespace AlphaVantage.Net.Stocks.Parsing
{
    public class AlphaVantageJsonParser<T> : IAlphaVantageJsonParser<T>
    {
        public T ParseApiResponse(string jsonString)
        {
            // Change None to 0 so as to the value can be converted to long type
            jsonString = jsonString
                .Replace("None", "")
                .Replace("\"-\"", "\"\"");

            return JsonConvert.DeserializeObject<T>(jsonString, new JsonSerializerSettings()
            {
                NullValueHandling = NullValueHandling.Ignore
            }) ?? throw new InvalidOperationException("AlphaVantageJsonParser<T> failed");
        }
    }
}