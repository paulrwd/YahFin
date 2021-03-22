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

                return "Bear";

            }
            else if(jc.Open < jc.Close)
            {
                if (jc.Close - jc.Open < half_percent)
                {
                    return "Bull doji";
                }

                return "Bull";
            }
            else if (jc.Open == jc.Close)
            {
                return "Doji";
            }

            return "";
        }
    }
}
