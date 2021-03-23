using System;
using System.Collections.Generic;
using System.Text;
using YahFin.QuoteChart_Classes;

namespace YahFin.Models
{
    public class Chart
    {
        public List<JapCandle> Candles { get; set; }

        public Chart()
        {
            Candles = new List<JapCandle>();
        }

        public Chart(QuoteChart getchart)
        {
            Candles = new List<JapCandle>();
            for (int i = 0; i < getchart.Chart.Result[0].Timestamp.Count; i++)
            {
                JapCandle jc = new JapCandle
                (
                getchart.Chart.Result[0].Timestamp[i],
                getchart.Chart.Result[0].Indicators.Quote[0].Open[i],
                getchart.Chart.Result[0].Indicators.Quote[0].Close[i],
                getchart.Chart.Result[0].Indicators.Quote[0].Low[i],
                getchart.Chart.Result[0].Indicators.Quote[0].High[i],
                getchart.Chart.Result[0].Indicators.Adjclose[0].adjclose[i],
                getchart.Chart.Result[0].Indicators.Quote[0].Volume[i]
                );
                Candles.Add(jc);
            }

        }
    }
}
