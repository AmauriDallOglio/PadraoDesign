using CleanArchitecture.Api.Nucleo.Core.Entities;

namespace CleanArchitecture.Api.Nucleo.Infrastructure.Persistence
{
    public class MeuContextoEmMemoria
    {
        public List<Usuario> Usuarios { get; set; } = new();

        public Task SaveChangesAsync()
        {
            return Task.CompletedTask;
        }
    }
}
