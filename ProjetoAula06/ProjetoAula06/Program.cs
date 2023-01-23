using ProjetoAula06.Controllers;
using ProjetoAula06.Interfaces;

var funcionarioController = new FuncionarioController();

Console.WriteLine("Escolha a opção desejada: ");
Console.Write("1 - Cadastrar || 2 - Atualizar || 3 - Deletar || 4 - Mostrar Todos Funcionários || 5 - Sair "); 
var opcao = Console.ReadLine();
var rodarPrograma = true;
while (rodarPrograma)
{
    switch (opcao)
    {
        case "1":
           
            funcionarioController.CadastrarFuncionario();
            break;
        case "2":

            break;
        case "5":
            Console.Write("Deseja realmente sai? || 1 - Sim || 2 - Não: " );
            var opcaoSair = Console.ReadLine();
            if(opcaoSair == "1")
            {
                Console.WriteLine("Obrigado, até a próxima!");
                rodarPrograma = false;
            }
            
            break;
    }
}
