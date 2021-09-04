using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace PruebaMovistar.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {


        [HttpGet("{n}")]
        public Respuesta Get(int n)
        {
            Respuesta res = new Respuesta();
            ObjetoFibonacci obj = new ObjetoFibonacci();
            res = obj.Fibonacci(n);
            return res;
        }
        [HttpPost]
        public string Calcular(ObjetoCuadratica obj)
        {
            Resultado resp = new Resultado();
            ObjetoCuadratica cuadratica = new ObjetoCuadratica();
            resp = cuadratica.calcular(obj);
            return resp.descripcion;
        }
    }
}
