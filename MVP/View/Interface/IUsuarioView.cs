namespace MVP.View.Interface
{
    public interface IUsuarioView
    {
        string UsuarioNome { get; set; }
        string UsuarioEmail { get; set; }
        void ApresentarMensagem(string mensagem);
        void ObterDadosUsuario();
    }
}
