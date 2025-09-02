using PrimeraApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace PrimeraApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private static List<ResponseUser> users = new List<ResponseUser>()
        {
            new ResponseUser {Nombre = "Andrés", Edad = 22, Categoria = "mayor de edad"},
            new ResponseUser {Nombre = "Camila", Edad = 9, Categoria = "menor de edad"},
            new ResponseUser {Nombre = "Ricardo", Edad = 71, Categoria = "mayor de edad"},
            new ResponseUser {Nombre = "Valeria", Edad = 15, Categoria = "menor de edad"},
            new ResponseUser {Nombre = "Martín", Edad = 34, Categoria = "mayor de edad"},
            new ResponseUser {Nombre = "Luciana", Edad = 6, Categoria = "menor de edad"},
            new ResponseUser {Nombre = "Elena", Edad = 80, Categoria = "mayor de edad"}

        };

        [HttpGet]
        [Route("GetUsers")]
        public IEnumerable<ResponseUser> GetUsers()
        {
            return users;
        }

        [HttpPost]
        [Route("CreateUser")]
        public ActionResult<ResponseUser> CreateUser(RequestUser requestUser)
        {
            if (requestUser.Edad < 0)
            {
                return BadRequest("La edad no puede ser negativa.");
            }

            var responseUser = new ResponseUser
            {
                Nombre = requestUser.Nombre,
                Edad = requestUser.Edad,
                Categoria = requestUser.Edad >= 18 ? "mayor de edad" : "menor de edad"
            };

            users.Add(responseUser);
            return Ok(responseUser);
            //sdvsdvds
        }
    }

}