using System;
using System.Collections.Generic;
using System.Text;
using YahFin.Models;
using YahFin.QuotePrice_Classes;
using YahFin.QuoteChart_Classes;


namespace YahFin
{
    public class Helper
    {
        public static void JapCandleInstall(ref JapCandle jc1, QuoteChart getchart1, int v)
        {
            jc1.open = getchart1.Chart.Result[0].Indicators.Quote[0].Open[v];
            jc1.close = getchart1.Chart.Result[0].Indicators.Quote[0].Close[v];
            jc1.low = getchart1.Chart.Result[0].Indicators.Quote[0].Low[v];
            jc1.high = getchart1.Chart.Result[0].Indicators.Quote[0].High[v];
            jc1.adjclose = getchart1.Chart.Result[0].Indicators.Adjclose[0].adjclose[v];
            jc1.volume = getchart1.Chart.Result[0].Indicators.Quote[0].Volume[v];
        }
    }
}
