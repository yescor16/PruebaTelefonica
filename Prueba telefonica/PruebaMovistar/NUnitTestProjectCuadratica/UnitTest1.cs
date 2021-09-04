using NUnit.Framework;

namespace NUnitTestProjectCuadratica
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
            PruebaMovistar.ObjetoCuadratica objCuad = new PruebaMovistar.ObjetoCuadratica();
            objCuad.a = 1;
            objCuad.b = 1;
            objCuad.c = 1;
            controller.Calcular(objCuad);
        }
    }
}