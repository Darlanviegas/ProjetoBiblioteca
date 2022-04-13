namespace Projeto_Biblioteca
{
    public class Usuarios
    {
        public string Nome  {get; set;}
    }
    public class Livros
    {
        public string Titulo  {get; set;}
        public string AnoPublicacao  {get; set;}
        public string Edicao  {get; set;}
        public string Editora  {get; set;}
        public string Autor  {get; set;}
        public string Classificacao  {get; set;}
        public string Idioma  {get; set;}
        public bool Disponibilidade  {get; set;}
    }
    public class Editoras
    {
        public string NomeEditora  {get; set;}
        public string Cidade  {get; set;}
    }
    public class Emprestimos
    {
        public string LivroEmprestado  {get; set;}
        public string DataEmprestimo  {get; set;}
    }
    public class Clientes:Usuarios
    {
        public string Curso  {get; set;}
        public string DataInicio  {get; set;}
        public string DataTerminoPrevista  {get; set;}
    }
    public class Funcionarios:Usuarios
    {
        public string Senha {get; set;}
        public string DataEmprestimo  {get; set;}
    }
}