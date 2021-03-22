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
            jc1.Open = getchart1.Chart.Result[0].Indicators.Quote[0].Open[v];
            jc1.Close = getchart1.Chart.Result[0].Indicators.Quote[0].Close[v];
            jc1.Low = getchart1.Chart.Result[0].Indicators.Quote[0].Low[v];
            jc1.High = getchart1.Chart.Result[0].Indicators.Quote[0].High[v];
            jc1.Adjclose = getchart1.Chart.Result[0].Indicators.Adjclose[0].adjclose[v];
            jc1.Volume = getchart1.Chart.Result[0].Indicators.Quote[0].Volume[v];
        }

        static long ttime(DateTime datetime)
        {
            DateTime origin = new DateTime(1970, 1, 1, 0, 0, 0, 0);
            TimeSpan diff = datetime - origin;
            return Convert.ToInt64(Math.Floor(diff.TotalSeconds));
        }

        public static DateTime UnixTimeStampToDateTime(int unixTimeStamp)
        {
            System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddSeconds(unixTimeStamp).ToLocalTime();
            return dtDateTime;
        }
    }
}
