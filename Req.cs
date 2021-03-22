using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.IO;
using ServiceStack;
//using System.Text.Json;
using System.Text.Json.Serialization;
using ServiceStack.Text;
using YahFin.QuotePrice_Classes;
using YahFin.QuoteChart_Classes;

namespace YahFin
{
    public class Req
    {

        //        https://query1.finance.yahoo.com/v8/finance/chart/AAPL?interval=2m
        //        https://query1.finance.yahoo.com/v10/finance/quoteSummary/AAPL?modules=assetProfile%2CearningsHistory
        //https://query1.finance.yahoo.com/v8/finance/chart/AAPL?symbol=AAPL&period1=0&period2=9999999999&interval=1d&includePrePost=true&events=div%2Csplit
        //https://query1.finance.yahoo.com/v7/finance/quote?symbols=UNP&fields=ebitda,shortRatio,priceToSales
        //https://query1.finance.yahoo.com/v7/finance/quote?lang=en-US&region=US&corsDomain=finance.yahoo.com&fields=symbol,longName,shortName,priceHint,regularMarketPrice,regularMarketChange,regularMarketChangePercent,currency,regularMarketTime,regularMarketVolume,quantity,averageDailyVolume3Month,regularMarketDayHigh,regularMarketDayLow,regularMarketPrice,regularMarketOpen,fiftyTwoWeekHigh,fiftyTwoWeekLow,regularMarketPrice,regularMarketOpen,sparkline,marketCap&symbols=000001.SS,600600.SS
        //        https://query1.finance.yahoo.com/v1/finance/search?q=dax&quotesCount=6&newsCount=0&quotesQueryId=tss_match_phrase_query&multiQuoteQueryId=multi_quote_single_token_query&enableCb=true
        //http://d.yimg.com/aq/autoc?query=a&region=US&lang=en-US&callback=YAHOO.util.ScriptNodeDataSource.callbacks
        //https://autoc.finance.yahoo.com/autoc?query=PLUG&region=1&lang=en

//        https://query1.finance.yahoo.com/v10/finance/quoteSummary/AAPL?modules=assetProfile%2CearningsHistory
 
//https://query1.finance.yahoo.com/v10/finance/quoteSummary/AAPL?modules=defaultKeyStatistics
//https://query1.finance.yahoo.com/v10/finance/quoteSummary/AAPL?modules=financialData
//https://query1.finance.yahoo.com/v10/finance/quoteSummary/AAPL?modules=assetProfile
 
 
//https://query1.finance.yahoo.com/v8/finance/chart/AAPL?symbol=AAPL&period1=0&period2=9999999999&interval=1d&includePrePost=true&events=div%2Csplit
 
//https://query1.finance.yahoo.com/v7/finance/quote?formatted=true&crumb=KRXGDVywE2G&lang=de-DE&region=DE&symbols=FRE.DE%2CFME.DE%2CALV.DE%2CBMW.DE%2CWDI.DE%2CBEI.DE%2CLIN.DE%2CHEI.DE%2CBAYN.DE%2CDBK.DE%2CLHA.DE%2CADS.DE%2C1COV.DE%2CVOW3.DE%2CDTE.DE%2CTKA.DE%2CRWE.DE%2CDPW.DE%2CDB1.DE%2CCON.DE%2CIFX.DE%2CBAS.DE%2CMRK.DE%2CSIE.DE%2CEOAN.DE%2CVNA.DE%2CHEN3.DE%2CMUV2.DE%2CSAP.DE%2CDAI.DE&fields=messageBoardId%2ClongName%2CshortName%2CmarketCap%2CunderlyingSymbol%2CunderlyingExchangeSymbol%2CheadSymbolAsString%2CregularMarketPrice%2CregularMarketChange%2CregularMarketChangePercent%2CregularMarketVolume%2Cuuid%2CregularMarketOpen%2CfiftyTwoWeekLow%2CfiftyTwoWeekHigh&corsDomain=de.finance.yahoo.com






        public static QuotePrice Price(string Ticker)
        {            
            WebRequest wrGETURL = WebRequest.Create("https://query1.finance.yahoo.com/v10/finance/quoteSummary/" + Ticker + "?modules=price");
            var sss = wrGETURL.GetResponse().ReadToEnd();
            try
            {
                QuotePrice QP = JsonSerializer.DeserializeFromString<QuotePrice>(sss);
                return QP;
            }
            catch
            {
                return null;
            }            
        }

        public static QuoteChart GetChart(string Ticker, string interval, string range)
        {
            WebRequest wrGETURL = WebRequest.Create("https://query1.finance.yahoo.com/v8/finance/chart/" + Ticker + "?interval=" + interval + "&range=" + range);
            var sss = wrGETURL.GetResponse().ReadToEnd();
            try 
            {
                QuoteChart QC = JsonSerializer.DeserializeFromString<QuoteChart>(sss);
                return QC;
            }
            catch
            {
                return null;
            }
        }

        




    }
}
