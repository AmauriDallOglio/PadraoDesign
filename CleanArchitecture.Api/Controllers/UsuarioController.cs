using CleanArchitecture.Api.Nucleo.Application.DTOs;
using CleanArchitecture.Api.Nucleo.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly UsuarioServico _usuarioService;

        public UsuarioController(UsuarioServico usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [HttpGet("ObterTodos")]
        public async Task<IActionResult> ObterTodos()
        {
            var usuarios = await _usuarioService.ObterTodosUsuariosAsync();
            return Ok(usuarios);
        }

        [HttpPost("Adicionar")]
        public async Task<IActionResult> Adicionar([FromBody] UsuarioDTO usuarioDto)
        {
            var usuario = await _usuarioService.CadastrarUsuarioAsync(usuarioDto);
            return CreatedAtAction(nameof(ObterTodos), new { id = usuario.Id }, usuario);
        }
    }
}
