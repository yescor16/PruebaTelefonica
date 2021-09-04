using NUnit.Framework;


namespace NUnitTestProjectFibonacci
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

      
        [Test]
        public void Test1()
        {
            var controller = new PruebaMovistar.Controllers.WeatherForecastController();
            PruebaMovistar.ObjetoFibonacci fibo = new PruebaMovistar.ObjetoFibonacci();
            int n = 4;
            fibo.Fibonacci(n);
        }
    }
}