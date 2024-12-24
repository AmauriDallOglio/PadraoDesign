using MVP.View.Interface;

namespace MVP.View
{
    public class UsuarioView : IUsuarioView
    {
        public string UsuarioNome { get; set; } = string.Empty;
        public string UsuarioEmail { get; set; } = string.Empty;

        public void ApresentarMensagem(string mensagem)
        {
            Console.WriteLine(mensagem);
        }

        public void ObterDadosUsuario()
        {
            Console.Write("Digite o nome do usuário: ");
            UsuarioNome = Console.ReadLine();

            Console.Write("Digite o email do usuário: ");
            UsuarioEmail = Console.ReadLine();
        }
    }
}
