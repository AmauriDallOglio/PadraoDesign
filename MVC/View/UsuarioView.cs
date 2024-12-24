namespace MVC.View
{
    public class UsuarioView
    {
        public void ApresentaMensagem(string mensagem)
        {
            Console.WriteLine(mensagem);
        }

        public (string nome, string email) ObterDadosUsuario()
        {
            Console.Write("Digite o nome do usuário: ");
            string nome = Console.ReadLine();

            Console.Write("Digite o email do usuário: ");
            string email = Console.ReadLine();

            return (nome, email);
        }
    }
}
