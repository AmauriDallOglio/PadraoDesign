using MVC.Model;
using MVC.View;

namespace MVC.Controller
{
    public class UsuarioController
    {
        private readonly UsuarioModel _model;
        private readonly UsuarioView _view;

        public UsuarioController(UsuarioModel model, UsuarioView view)
        {
            _model = model;
            _view = view;
        }

        public void InserirUsuario()
        {
            var (nome, email) = _view.ObterDadosUsuario();
            _model.Nome = nome;
            _model.Email = email;

            if (_model.Salvar())
            {
                _view.ApresentaMensagem($"Usuário {nome} cadastrado com sucesso!");
            }
            else
            {
                _view.ApresentaMensagem("Erro ao salvar usuário.");
            }
        }
    }
}
