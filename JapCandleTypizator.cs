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
            double half_percent = jc.close / 500;

            if(jc.open > jc.close)
            {
                if(jc.open - jc.close < half_percent)
                {
                    return " Bear doji";
                }

                return "Bear";

            }
            else if(jc.open < jc.close)
            {
                if (jc.close - jc.open < half_percent)
                {
                    return "Bull doji";
                }

                return "Bull";
            }
            else if (jc.open == jc.close)
            {
                return "Doji";
            }

            return "";
        }
    }
}
