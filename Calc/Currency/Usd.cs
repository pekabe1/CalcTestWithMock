using System;
using System.Collections.Generic;
using System.Text;

namespace Calc.Currency
{
    class Usd : ICurrency
    {
        public decimal currencyRate { get; } = 4M;

        public decimal GetRate()
        {
            return currencyRate;
        }
    }
}
