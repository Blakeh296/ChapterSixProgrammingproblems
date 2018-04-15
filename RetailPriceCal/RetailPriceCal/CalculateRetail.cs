using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailPriceCal
{
    class WholeSaleToRetail
    {  
        public static double CalculateRetail (double WholeSale, double percent)
        {
            double Retail;
  
            Retail = WholeSale + (WholeSale * (percent / 100));

            return Retail;
        }
    }
}
