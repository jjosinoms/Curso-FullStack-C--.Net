using ExercicioAula04.Entities;
using ExercicioAula04.Enums;
using ExercicioAula04.Interfaces;
using ExercicioAula04.Repositories;

var funcionario = new Funcionario();
funcionario.Id = Guid.NewGuid();
funcionario.Departamento = new Departamento();
funcionario.Departamento.Id = Guid.NewGuid();
var funcionarioRepository = new FuncionarioRepository();


Console.WriteLine("Digite o Nome do funcionário: ");
funcionario.Nome = Console.ReadLine();

Console.WriteLine("Digite o Salário do funcionário: ");
funcionario.Salario = double.Parse(Console.ReadLine());

Console.WriteLine("Digite a Data de Admissão do funcionário: ");
funcionario.DataAdmissao = DateTime.Parse(Console.ReadLine());

Console.WriteLine("Escolha o Departamento do Funcionario: 1-Vendas / 2-Comercial / 3-Estoque ");
var opcao = Console.ReadLine();

Console.WriteLine("Digite uma Descricao do Departamento: ");
funcionario.Departamento.Descricao = Console.ReadLine();

switch (opcao)
{
    case "1":
        funcionario.Departamento.TipoDepartamento = TipoDepartamento.Vendas;
        break;
    case "2":
        funcionario.Departamento.TipoDepartamento = TipoDepartamento.Comercial;
        break;
    case "3":
        funcionario.Departamento.TipoDepartamento = TipoDepartamento.Estoque;
        break;

}

funcionarioRepository.adicionarFuncionario(funcionario);


