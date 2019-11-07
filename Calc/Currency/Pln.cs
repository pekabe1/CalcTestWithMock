using System;
using System.Collections.Generic;
using System.Text;

namespace Calc.Currency
{
   public class Pln : ICurrency
    {
        public decimal currencyRate { get; } = 1M;
        public decimal GetRate()
        {
            return currencyRate;
        }
    }
}
