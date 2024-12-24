using MVC.Controller;
using MVC.Model;
using MVC.View;

namespace MVC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Estrutura do Projeto (MVC): \r\n Models: Representa os dados e a lógica de negócio. \r\n Views: Responsável por interagir com o usuário. \r\n Controllers: Recebe as entradas do usuário, interage com o Model e atualiza a View.");
            
            var model = new UsuarioModel();
            var view = new UsuarioView();
            var controller = new UsuarioController(model, view);

            controller.InserirUsuario();

        }
    }
}
