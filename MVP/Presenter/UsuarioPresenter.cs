using MVP.Model;
using MVP.View.Interface;

namespace MVP.Presenter
{
    public class UsuarioPresenter
    {
        private readonly IUsuarioView _view;
        private readonly UsuarioModel _model;

        public UsuarioPresenter(IUsuarioView view, UsuarioModel model)
        {
            _view = view;
            _model = model;
        }

        public void InserirUsuario()
        {
            _view.ObterDadosUsuario();

            _model.Nome = _view.UsuarioNome;
            _model.Email = _view.UsuarioEmail;

            if (_model.Salvar())
            {
                _view.ApresentarMensagem($"Usuário {_view.UsuarioNome} cadastrado com sucesso!");
            }
            else
            {
                _view.ApresentarMensagem("Erro ao salvar usuário.");
            }
        }
    }
}
