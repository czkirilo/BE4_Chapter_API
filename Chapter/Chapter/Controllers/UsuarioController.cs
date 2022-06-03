using Chapter.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Chapter.Controllers
{
    [Produces("application/json")]  
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioRepository _iUsuarioRepository;

        public UsuarioController (IUsuarioRepository usuarioRepository)
        {
            _iUsuarioRepository = usuarioRepository;    
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
       [HttpGet]
        public IActionResult Listar()
        {
            try
            {
                return Ok(_iUsuarioRepository.Listar());
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
