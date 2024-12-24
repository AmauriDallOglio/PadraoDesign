using MVP.Model;
using MVP.Presenter;
using MVP.View;

namespace MVP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Estrutura do Projeto (MVP): \r\n Models: Representa os dados e a lógica de negócio. \r\n Views: Define uma interface que é implementada por uma classe concreta para interação. \r\n Presenters: Contém toda a lógica de apresentação.");

            var model = new UsuarioModel();
            var view = new UsuarioView();
            var presenter = new UsuarioPresenter(view, model);

            presenter.CreateUser();
        }
    }
}
