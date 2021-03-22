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
                    return "Красная дожи";
                }

                return "Красная";

            }
            else if(jc.open < jc.close)
            {
                if (jc.close - jc.open < half_percent)
                {
                    return "Зеленая дожи";
                }

                return "Зеленая";
            }
            else if (jc.open == jc.close)
            {
                return "Дожи";
            }

            return "";
        }
    }
}
