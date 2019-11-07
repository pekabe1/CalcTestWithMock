using NUnit.Framework;
using Moq;
using Calc.Currency;
using Calc.CurrencyConverter;

namespace Tests
{
    public class ExchangeTests
    {
        Mock<ICurrency> mock;
        [SetUp]
        public void Setup()
        {
            mock = new Mock<ICurrency>();
        }

        [Test]
        public void ConvertToZloty_Pass2Euro_Returns()
        {
            mock.Setup(p => p.GetRate()).Returns(1.66M);

            Exchange exchange = new Exchange(mock.Object);
            var result = exchange.ConvertToZloty(5);
            Assert.AreEqual(8.3M, result);
        }
    }
}