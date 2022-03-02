using BibliotecaClasses;

Produto produto = new();
produto.Codigo = 1;
produto.Nome = "Iphone X";
produto.Descricao = "Celular SmartPhone";
produto.QteEstoque = 40;
Console.WriteLine($"--------------------- PRODUTO ------------------");
Console.WriteLine($"Código: {produto.Codigo}");
Console.WriteLine($"Nome: {produto.Nome}");
Console.WriteLine($"Descrição: {produto.Descricao}");
Console.WriteLine($"Estoque: {produto.QteEstoque}");
Console.WriteLine($"------------------------------------------------");

Funcionario funcionario = new Funcionario();
funcionario.Matricula = 215;
funcionario.Nome = "vinicius";
funcionario.Salario = 4560.00M;
funcionario.Funcao = "Operador";
funcionario.DataAdmissao = new DateTime(2012, 04, 24, 12,00,00);
Console.WriteLine($"------------------- FÚNCIONARIO ------------------");
Console.WriteLine($"Matricula: {funcionario.Matricula}");
Console.WriteLine($"Nome: {funcionario.Nome}");
Console.WriteLine($"Salário: {funcionario.Salario}");
Console.WriteLine($"Função: {funcionario.Funcao}");
Console.WriteLine($"Admissão: {funcionario.DataAdmissao}");
Console.WriteLine($"---------------------------------------------------");

Usuario usuario = new Usuario();
usuario.Nome = "Vinicius";
usuario.Login = "Vini-teste";
usuario.Senha = "2315";
Console.WriteLine($"----------------- USUÁRIO CONSTRUTOR PADRÃO --------------------");
Console.WriteLine($"Nome: {usuario.Nome}");
Console.WriteLine($"Senha: {usuario.Senha}");
Console.WriteLine($"Login: {usuario.Login}");
Console.WriteLine($"-----------------------------------------------------------------");


Usuario usuarioRedeSocial = new Usuario("Paula Rosa", "123", "paula.rosa");
Console.WriteLine($"----------------- USUÁRIO CONSTRUTOR COM ARGUMENTOS --------------");
Console.WriteLine($"Nome Rede Social: {usuarioRedeSocial.Nome}");
Console.WriteLine($"Senha Rede Social: {usuarioRedeSocial.Senha}");
Console.WriteLine($"Login Rede Social: {usuarioRedeSocial.Login}");
Console.WriteLine($"------------------------------------------------------------------");

int resultadoSoma = Calculadora.Somar(4, 5);
int resultadoMultiplicacao = Calculadora.Multiplicar(4, 5);
int resultadoSubtrair = Calculadora.Subtrair(4, 5);
Console.WriteLine("---------------------- CALCULADORA - Classe Estática ---------------------");
Console.WriteLine($"Resultado Soma: {resultadoSoma}");
Console.WriteLine($"Resultado Multiplicação: {resultadoMultiplicacao}");
Console.WriteLine($"Resultado Subtração: {resultadoSubtrair}");
Console.WriteLine($"-------------------------------------------------------------------------");