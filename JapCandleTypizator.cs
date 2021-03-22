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
            if(jc.open > jc.close)
            {
                return "Красная";
            }
            else if(jc.open < jc.close)
            {
                return "Зеленая";
            }

            return "";
        }
    }
}
