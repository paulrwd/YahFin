using System;
using System.Collections.Generic;
using System.Text;
using YahFin.QuoteChart_Classes;
using QuikSharp;
using QuikSharp.DataStructures.Transaction;
using QuikSharp.DataStructures;

namespace YahFin.Models
{
    public class Chart
    {
        private List<Candle> toolCandles;

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

        

        public Chart(List<Candle> toolCandles)
        {
            Candles = new List<JapCandle>();
            for (int i = 0; i < toolCandles.Count; i++)
            {
                JapCandle jc = new JapCandle
                (
                Helper.QuikDateTimeToTimeStamp(toolCandles[i].Datetime),
                Convert.ToDouble(toolCandles[i].Open),
                Convert.ToDouble(toolCandles[i].Close),
                Convert.ToDouble(toolCandles[i].Low),
                Convert.ToDouble(toolCandles[i].High),
                Convert.ToDouble(toolCandles[i].Close),
                Convert.ToInt64(toolCandles[i].Volume)
                );
                Candles.Add(jc);
            }
            this.toolCandles = toolCandles;
        }
    }
}
