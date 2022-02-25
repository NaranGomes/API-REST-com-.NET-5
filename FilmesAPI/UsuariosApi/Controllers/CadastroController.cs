using FluentResults;
using Microsoft.AspNetCore.Mvc;
using UsuariosApi.Data.Dtos;
using UsuariosApi.Services;

namespace UsuariosApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CadastroController : ControllerBase
    {
        private CadastroService _cadastroService;

        public CadastroController(CadastroService cadastroService)
        {
            _cadastroService = cadastroService;
        }

        [HttpPost]
        public IActionResult CadastraUsuario(CreateUsuarioDto CreateDto)
        {
            Result resultado = _cadastroService.CadastraUsusario(CreateDto);
            if (resultado.IsFailed) return StatusCode(500);
            return Ok(resultado.Successes);
        }
    }
}
