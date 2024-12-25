using CleanArchitecture.Api.Nucleo.Application.DTOs;
using CleanArchitecture.Api.Nucleo.Core.Entities;
using CleanArchitecture.Api.Nucleo.Core.Interfaces;

namespace CleanArchitecture.Api.Nucleo.Application.Services
{
    public class UsuarioServico
    {
        private readonly IUsuarioRepositorioEmMemoria _usuarioRepository;

        public UsuarioServico(IUsuarioRepositorioEmMemoria usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public async Task<Usuario> CadastrarUsuarioAsync(UsuarioDTO usuarioDto)
        {
            ValidarUsuarioDto(usuarioDto);

            var usuario = new Usuario
            {
                Nome = usuarioDto.Nome,
                Email = usuarioDto.Email,
                Senha = usuarioDto.Senha
            };

            return await _usuarioRepository.AdicionarAsync(usuario);
        }

        public Task<IEnumerable<Usuario>> ObterTodosUsuariosAsync()
        {
            return _usuarioRepository.ObterTodosAsync();
        }

        public Task<Usuario?> ObterUsuarioPorIdAsync(int id)
        {
            return _usuarioRepository.ObterPorIdAsync(id);
        }

        public Task AtualizarUsuarioAsync(Usuario usuario)
        {
            return _usuarioRepository.AtualizarAsync(usuario);
        }

        public Task RemoverUsuarioAsync(int id)
        {
            return _usuarioRepository.RemoverAsync(id);
        }

        private static void ValidarUsuarioDto(UsuarioDTO usuarioDto)
        {
            if (string.IsNullOrWhiteSpace(usuarioDto.Nome))
                throw new ArgumentException("O nome do usuário é obrigatório.");
            if (string.IsNullOrWhiteSpace(usuarioDto.Email))
                throw new ArgumentException("O e-mail do usuário é obrigatório.");
            if (string.IsNullOrWhiteSpace(usuarioDto.Senha))
                throw new ArgumentException("A senha do usuário é obrigatória.");
        }
    }
}

