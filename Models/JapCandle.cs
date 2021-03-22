using System;
using System.Collections.Generic;
using System.Text;

namespace YahFin.Models
{
    public class JapCandle
    {
        public double Open { get; set; }
        public double Close { get; set; }
        public double Low { get; set; }
        public double High { get; set; }

        public double Adjclose { get; set; }
        public long Volume { get; set; }

        public double Body { get; private set; }

        public JapCandle(double open, double close, double low, double high, double adjclose, long volume)
        {
            Open = open;
            Close = close;
            Low = low;
            High = high;
            Adjclose = adjclose;
            Volume = volume;
            Body = Math.Abs(open - close);
        }
          

    }
}
