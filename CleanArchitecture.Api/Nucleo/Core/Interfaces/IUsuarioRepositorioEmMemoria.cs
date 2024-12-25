using CleanArchitecture.Api.Nucleo.Core.Entities;

namespace CleanArchitecture.Api.Nucleo.Core.Interfaces
{
    public interface IUsuarioRepositorioEmMemoria
    {
        Task<IEnumerable<Usuario>> ObterTodosAsync();
        Task<Usuario?> ObterPorIdAsync(int id);
        Task<Usuario> AdicionarAsync(Usuario usuario);
        Task AtualizarAsync(Usuario usuario);
        Task RemoverAsync(int id);
    }
}
