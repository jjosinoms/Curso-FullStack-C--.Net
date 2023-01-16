using ProjetoAula04.Entities;
using ProjetoAula04.Enums;
using ProjetoAula04.Interfaces;
using ProjetoAula04.Repositories;

var funcionario = new Funcionario();


funcionario.Id = Guid.NewGuid();
funcionario.Nome = "Jonas";
funcionario.Cpf = "12345678900";
funcionario.Matricula = "2023ABC";
funcionario.DataAdmissao = DateTime.Now;
funcionario.TipoContratacao = TipoContratacao.CLT;

Console.WriteLine("Informe 1- JSON ou 2 - XML: ");
var tipo = int.Parse(Console.ReadLine());

//POLIMORFISMO
IFuncionarioRepository? funcionarioRepository = null; 
switch (tipo)
{
    case 1:
        //POLIMORFISMO
        funcionarioRepository = new FuncionarioRepositoryJSON();
        
        break;
    case 2:
        //POLIMORFISMO
        funcionarioRepository = new FuncionarioRepositoryXML();
       
        break;
}

funcionarioRepository.exportarFuncionario(funcionario);

