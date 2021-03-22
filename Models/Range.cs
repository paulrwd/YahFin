using System;
using System.Collections.Generic;
using System.Text;

namespace YahFin.Models
{
    public class Range
    {
        public DateTime dateStart { get; set; } = DateTime.MinValue;
        public DateTime dateNow { get; } = DateTime.Now;


    }
}
