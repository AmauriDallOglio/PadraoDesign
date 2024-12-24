namespace MVC.Model
{
    public class UsuarioModel
    {
        public string Nome { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty ;

        public bool Salvar()
        {
            Console.WriteLine($"Usuário '{Nome}' / '{Email}', salvo com sucesso!");
            return true;
        }
    }
}
