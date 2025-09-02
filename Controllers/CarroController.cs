using PrimeraApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace PrimeraApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarroController
    {
        private List<Carro> carros = new()
            {
                new Carro { Color = "Azul", Placa = "TX15"},
                new Carro { Color = "Azul", Placa = "XY95"}
            };
        [HttpGet]
        public IEnumerable<Carro> GetCarros()
        {
            return carros;
        }
        [HttpPost]
        [Route("CreateCarro")]
        public ActionResult<Carro> CreateCarro(Carro carro)
        {
            carros.Add(carro);
            return carro;
        }
    }
}
