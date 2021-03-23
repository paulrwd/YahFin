using System;
using System.Collections.Generic;
using System.Text;
using YahFin.Models;

namespace YahFin
{
    public class JapCandleTypizator
    {
        public static string GetType(JapCandle jc)
        {
            double half_percent = jc.Close / 500;

            if(jc.Open > jc.Close)
            {
                if(jc.Open - jc.Close < half_percent)
                {
                    return " Bear doji";
                }
                if(jc.UpperShadow == 0 && jc.LowerShadow == 0)
                {
                    return " Bear marubozu";
                }

                return "Bear";

            }
            else if(jc.Open < jc.Close)
            {
                if (jc.Close - jc.Open < half_percent)
                {
                    return "Bull doji";
                }
                if (jc.UpperShadow == 0 && jc.LowerShadow == 0)
                {
                    return " Bull marubozu";
                }

                return "Bull";
            }
            else if (jc.Open == jc.Close)
            {
                if(jc.Open == jc.Close && jc.Close == jc.Low && jc.High != jc.Low)
                {
                    return " Gravestone doji";
                }
                if (jc.Open == jc.Close && jc.Close == jc.High && jc.High != jc.Low)
                {
                    return " Dragonfly doji";
                }
                if ((jc.High + jc.Low)/2 == jc.Close && jc.High != jc.Low)
                {
                    return " Rickshaw";
                }

                return "Doji";
            }

            return "";
        }
    }
}
