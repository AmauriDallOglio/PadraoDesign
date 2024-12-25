using CleanArchitecture.Api.Nucleo.Core.Entities;
using CleanArchitecture.Api.Nucleo.Core.Interfaces;
using CleanArchitecture.Api.Nucleo.Infrastructure.Persistence;

namespace CleanArchitecture.Api.Nucleo.Infrastructure.Repositories
{
    public class UsuarioRepositorioEmMemoria : IUsuarioRepositorioEmMemoria
    {
        private readonly MeuContextoEmMemoria _contexto;

        public UsuarioRepositorioEmMemoria(MeuContextoEmMemoria contexto)
        {
            _contexto = contexto;
        }

        public Task<IEnumerable<Usuario>> ObterTodosAsync()
        {
            return Task.FromResult(_contexto.Usuarios.AsEnumerable());
        }

        public Task<Usuario?> ObterPorIdAsync(int id)
        {
            return Task.FromResult(_contexto.Usuarios.FirstOrDefault(u => u.Id == id));
        }

        public async Task<Usuario> AdicionarAsync(Usuario usuario)
        {
            usuario.Id = _contexto.Usuarios.Any() ? _contexto.Usuarios.Max(u => u.Id) + 1 : 1;
            _contexto.Usuarios.Add(usuario);
            await _contexto.SaveChangesAsync();
            return usuario;
        }

        public async Task AtualizarAsync(Usuario usuario)
        {
            var usuarioExistente = await ObterPorIdAsync(usuario.Id);
            if (usuarioExistente != null)
            {
                usuarioExistente.Nome = usuario.Nome;
                usuarioExistente.Email = usuario.Email;
                await _contexto.SaveChangesAsync();
            }
        }
        public async Task RemoverAsync(int id)
        {
            var usuario = await ObterPorIdAsync(id);
            if (usuario != null)
            {
                _contexto.Usuarios.Remove(usuario);
                await _contexto.SaveChangesAsync();
            }
        }
    }
}
