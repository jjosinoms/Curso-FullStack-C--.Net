/*
 * Crie um projeto em c# que leia os dados de un funcionario, informado pelo usuário
 * o funcionario sera composto de: Id, Nome, Cpf, Matricula, Data de Admissao e tambem 
 * deverá ter 1 Setor (Id, Nome) e Função (Id e Descrição) associados 
 * O programa deverá ler estes dados e gravar em arquivos em extensão JSON ou XML,
 * dependendo da escolha do usuário.
 * 
 */

//imprimindo..
using ProjetoAula02.Entities;
using ProjetoAula02.Repositories;
using System;

Console.WriteLine("\n *** CADASTRO DE FUNCIONÁRIOS ***\n");

var funcionario = new Funcionario();
funcionario.FuncaoFuncionario = new FuncaoFuncionario();
funcionario.SetorFuncionario = new SetorFuncionario();
funcionario.Id = Guid.NewGuid();
funcionario.FuncaoFuncionario.Id = Guid.NewGuid();
funcionario.SetorFuncionario.Id = Guid.NewGuid();

try
{
    Console.Write("Digite o Nome do funcionário:");
    funcionario.Nome = Console.ReadLine();
    Console.Write("Digite o CPF do funcionário:");
    funcionario.Cpf = Console.ReadLine();
    Console.Write("Digite a Matrícula do funcionário:");
    funcionario.Matricula = Console.ReadLine();
    Console.Write("Digite a Data de Admissão do funcionário:");
    funcionario.DataAdmissao = DateTime.Parse(Console.ReadLine());
    Console.Write("Digite o Setor do funcionário:");
    funcionario.SetorFuncionario.Nome = Console.ReadLine();
    Console.Write("Digite a Função do funcionário:");
    funcionario.FuncaoFuncionario.Descricao = Console.ReadLine();


    //exportação dos dados do cliente para arquivo..
    try
    {
        //criando um objeto ( variavel de instancia) para clienteRepository
        var funcionarioRepository = new CadastrarFuncionarioRepository();
        Console.WriteLine("Digite (1)JSON - (2)XML - (3) Bloco de notas");
        var opcao = Console.ReadLine();

        switch (opcao)
        {
            case "1":
                funcionarioRepository.ExportarJson(funcionario);
                Console.WriteLine("JSON gravado com sucesso!");
                break;
            case "2":
                funcionarioRepository.ExportarXml(funcionario);
                Console.WriteLine("XML gravado com sucesso!");
                break;
            case "3":
                funcionarioRepository.registrarFuncionario(funcionario);
                Console.WriteLine("Bloco de notas gravado com sucesso!");
                break;
            default:
                Console.WriteLine("Erro! Arquivo nao foi salvo!");
                break;
        }

    }
    catch (ArgumentException e)
    {
        Console.WriteLine(e.Message);
    }

}
catch (ArgumentException e)
{
    Console.WriteLine(e.Message);
}

//aguardar uma tecla para continuar..
Console.ReadKey();
