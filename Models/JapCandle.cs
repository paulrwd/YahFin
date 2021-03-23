using System;
using System.Collections.Generic;
using System.Text;

namespace YahFin.Models
{
    public class JapCandle
    {
        public long Timestamp { get; set; }
        public double Open { get; set; }
        public double Close { get; set; }
        public double Low { get; set; }
        public double High { get; set; }

        public double Adjclose { get; set; }
        public long Volume { get; set; }

        public double Body { get; private set; }
        public double UpperShadow { get; private set; }

        public double LowerShadow { get; private set; }

        public string Type { get; private set; }



        public JapCandle(long timestamp, double open, double close, double low, double high, double adjclose, long volume)
        {
            Timestamp = timestamp;
            Open = open;
            Close = close;
            Low = low;
            High = high;
            Adjclose = adjclose;
            Volume = volume;
            Body = Math.Abs(open - close);
            if(open < close)
            {
                UpperShadow = Math.Abs(high - close);
                LowerShadow = Math.Abs(open - low);
            }
            else if (close < open) 
            {
                UpperShadow = Math.Abs(high - open);
                LowerShadow = Math.Abs(close - low);
            }
            else 
            {
                UpperShadow = Math.Abs(high - close);
                LowerShadow = Math.Abs(open - low);
            }

            Type = JapCandleTypizator.GetType(this);
        }
          

    }
}
