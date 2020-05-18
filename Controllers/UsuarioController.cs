using System.Linq;
using Dapper_Mysql.Repository;
using Dapper_Mysql.Model;
using Microsoft.AspNetCore.Mvc;

namespace Dapper_Mysql.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioController(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        [HttpGet]
        [Produces(typeof(Usuario))]
        public IActionResult Get()
        {
            var pessoas = _usuarioRepository.GetAll();
            if (!pessoas.Any())
                return NoContent();
            return Ok(pessoas);
        }
    }
}