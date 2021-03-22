using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace YahFin.QuoteChart_Classes
{
    // Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
    public class Pre
    {
        [JsonPropertyName("timezone")]
        public string Timezone { get; set; }

        [JsonPropertyName("start")]
        public int Start { get; set; }

        [JsonPropertyName("end")]
        public int End { get; set; }

        [JsonPropertyName("gmtoffset")]
        public int Gmtoffset { get; set; }
    }

    public class Regular
    {
        [JsonPropertyName("timezone")]
        public string Timezone { get; set; }

        [JsonPropertyName("start")]
        public int Start { get; set; }

        [JsonPropertyName("end")]
        public int End { get; set; }

        [JsonPropertyName("gmtoffset")]
        public int Gmtoffset { get; set; }
    }

    public class Post
    {
        [JsonPropertyName("timezone")]
        public string Timezone { get; set; }

        [JsonPropertyName("start")]
        public int Start { get; set; }

        [JsonPropertyName("end")]
        public int End { get; set; }

        [JsonPropertyName("gmtoffset")]
        public int Gmtoffset { get; set; }
    }

    public class CurrentTradingPeriod
    {
        [JsonPropertyName("pre")]
        public Pre Pre { get; set; }

        [JsonPropertyName("regular")]
        public Regular Regular { get; set; }

        [JsonPropertyName("post")]
        public Post Post { get; set; }
    }

    public class Meta
    {
        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        [JsonPropertyName("symbol")]
        public string Symbol { get; set; }

        [JsonPropertyName("exchangeName")]
        public string ExchangeName { get; set; }

        [JsonPropertyName("instrumentType")]
        public string InstrumentType { get; set; }

        [JsonPropertyName("firstTradeDate")]
        public int FirstTradeDate { get; set; }

        [JsonPropertyName("regularMarketTime")]
        public int RegularMarketTime { get; set; }

        [JsonPropertyName("gmtoffset")]
        public int Gmtoffset { get; set; }

        [JsonPropertyName("timezone")]
        public string Timezone { get; set; }

        [JsonPropertyName("exchangeTimezoneName")]
        public string ExchangeTimezoneName { get; set; }

        [JsonPropertyName("regularMarketPrice")]
        public double RegularMarketPrice { get; set; }

        [JsonPropertyName("chartPreviousClose")]
        public double ChartPreviousClose { get; set; }

        [JsonPropertyName("priceHint")]
        public int PriceHint { get; set; }

        [JsonPropertyName("currentTradingPeriod")]
        public CurrentTradingPeriod CurrentTradingPeriod { get; set; }

        [JsonPropertyName("dataGranularity")]
        public string DataGranularity { get; set; }

        [JsonPropertyName("range")]
        public string Range { get; set; }

        [JsonPropertyName("validRanges")]
        public List<string> ValidRanges { get; set; }
    }

    public class Quote
    {
        [JsonPropertyName("open")]
        public List<double> Open { get; set; }

        [JsonPropertyName("high")]
        public List<double> High { get; set; }

        [JsonPropertyName("volume")]
        public List<int> Volume { get; set; }

        [JsonPropertyName("close")]
        public List<double> Close { get; set; }

        [JsonPropertyName("low")]
        public List<double> Low { get; set; }
    }

    public class Adjclose
    {
        [JsonPropertyName("adjclose")]
        public List<double> adjclose { get; set; }
    }

    public class Indicators
    {
        [JsonPropertyName("quote")]
        public List<Quote> Quote { get; set; }

        [JsonPropertyName("adjclose")]
        public List<Adjclose> Adjclose { get; set; }
    }

    public class Result
    {
        [JsonPropertyName("meta")]
        public Meta Meta { get; set; }

        [JsonPropertyName("timestamp")]
        public List<int> Timestamp { get; set; }

        [JsonPropertyName("indicators")]
        public Indicators Indicators { get; set; }
    }

    public class Chart
    {
        [JsonPropertyName("result")]
        public List<Result> Result { get; set; }

        [JsonPropertyName("error")]
        public object Error { get; set; }
    }

    public class QuoteChart
    {
        [JsonPropertyName("chart")]
        public Chart Chart { get; set; }
    }


}
