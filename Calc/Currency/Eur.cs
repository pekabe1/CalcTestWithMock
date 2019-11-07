using System;
using System.Collections.Generic;
using System.Text;

namespace Calc.Currency 
{
    class Eur : ICurrency
    {
       public decimal currencyRate { get; } = 3.14M;

     

        public decimal GetRate()
        {
            return currencyRate;
        }
    }
}
