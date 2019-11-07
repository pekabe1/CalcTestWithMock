using Calc.Currency;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calc.CurrencyConverter
{
    public class Exchange
    {

        private ICurrency _currency;
        public Exchange(ICurrency currency)
        {
            _currency = currency;
        }
        public decimal ConvertToZloty(int amount)
        {
            Pln pln = new Pln();
            return _currency.GetRate()* amount * pln.GetRate(); 
        }
        public decimal ConvertFromZloty(int amount)
        {
            Pln pln = new Pln();
            return (pln.GetRate() * amount) / _currency.GetRate();
        }
    }
}
