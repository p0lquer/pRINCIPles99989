using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KISS


{
    public class Restaurant
    {
        public decimal CalcTotal(decimal[] precio, decimal? tipPercentage)
        {
            decimal total = precio.Sum();
            _ = (tipPercentage.HasValue) ? total += total * (tipPercentage.Value / 100) : total = total * 100 / 10;
            return total;
        }
    }



   

}