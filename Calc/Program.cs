using Calc.Currency;
using Calc.CurrencyConverter;
using System;

namespace Calc
{
    class Program
    {
        static void Main(string[] args)
        {
            Exchange exchange = new Exchange(new Eur());

            Console.WriteLine(exchange.ConvertToZloty(5)); 
            Console.WriteLine(exchange.ConvertFromZloty(5)); 
        }
    }
}
