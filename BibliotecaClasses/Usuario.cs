namespace BibliotecaClasses
{
    public class Usuario
    {
        public string Login;
        public string Nome;
        public string Senha;

        public Usuario() { }

        public Usuario(string nome, string senha, string login)
        {
            Login = login;
            Senha = senha;
            Nome = nome;
        }
    }
}
