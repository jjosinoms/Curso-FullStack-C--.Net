using ProjetoAula05.Entities;
using ProjetoAula05.Interfaces;
using ProjetoAula05.Repositories;


IClienteRepository? clienteRepository = new ClienteRepository();

var programa = true;

while (programa)
{
    Console.Write("(1) - INSERIR CLIENTE");
    Console.Write("(2) - ALTERAR CLIENTE");
    Console.Write("(3) - EXCLUIR CLIENTE");
    Console.Write("(4) - CONSULTAR CLIENTE INDIVIDUAL");
    Console.Write("(5) - CONSULTAR TODOS OS CLIENTES");
    Console.Write("(10) - SAIR");
    Console.WriteLine("______________________");

    Console.Write("\nINFORME A OPÇÃO DESEJADA: ");
    var opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            try
            {
                var cliente = new Cliente();
                cliente.Id = Guid.NewGuid();

                Console.WriteLine("CADASTRO DE CLIENTE");
                Console.WriteLine("______________________");
                Console.Write("Digite o nome do Cliente: ");
                cliente.Nome = Console.ReadLine();
                Console.WriteLine("Digite o CPF do Cliente: ");
                cliente.Cpf = Console.ReadLine();
                Console.WriteLine("Digite a Data de Nascimento do Cliente: ");
                cliente.DataNascimento = DateTime.Parse(Console.ReadLine());


                clienteRepository.Inserir(cliente);

                Console.WriteLine("CLIENTE CADASTRADO COM SUCESSO");

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            break;
        case "2":
            try
            {
                var cliente = new Cliente();
                Console.WriteLine("ATUALIZAÇÃO DE CLIENTE");
                Console.WriteLine("______________________");
                Console.Write("Digite o ID do Cliente que deseja atualizar: ");
                cliente.Id = Guid.Parse(Console.ReadLine());
                Console.Write("Digite o nome do Cliente: ");
                cliente.Nome = Console.ReadLine();
                Console.WriteLine("Digite o CPF do Cliente: ");
                cliente.Cpf = Console.ReadLine();
                Console.WriteLine("Digite a Data de Nascimento do Cliente: ");
                cliente.DataNascimento = DateTime.Parse(Console.ReadLine());

                clienteRepository.Alterar(cliente);


                Console.WriteLine("CLIENTE ATUALIZADO COM SUCESSO");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            break;
        case "3":
            try
            {
                var cliente = new Cliente();
                Console.WriteLine("EXCLUSÃO DE CLIENTE");
                Console.WriteLine("______________________");
                Console.Write("Digite o ID do Cliente que deseja atualizar: ");
                cliente.Id = Guid.Parse(Console.ReadLine());

                clienteRepository.Deletar(cliente);

                Console.WriteLine("CLIENTE EXCLUIDO COM SUCESSO");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            break;
        case "4":
            try
            {
                var cliente = new Cliente();
                Console.WriteLine("BUSCA DE CLIENTE POR ID");
                Console.WriteLine("______________________");
                Console.Write("Digite o ID do Cliente que deseja atualizar: ");
                cliente.Id = Guid.Parse(Console.ReadLine());

                clienteRepository.MostrarClienteIndividual(cliente);
                Console.WriteLine($"ID DO CLIENTE: {cliente.Id}");
                Console.WriteLine($"NOME DO CLIENTE: {cliente.Nome}");
                Console.WriteLine($"CPF DO CLIENTE: {cliente.Cpf}");
                Console.WriteLine($"DATA NASCIMENTO DO CLIENTE: {cliente.DataNascimento}");

                Console.WriteLine("CLIENTE EXCLUIDO COM SUCESSO");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            break;
        case "5":
            try
            {
                clienteRepository.MostrarClientes();
                Console.WriteLine("Lista de Usuarios");
                Console.WriteLine("__________________________________");
                List<Cliente> clientes = clienteRepository.MostrarClientes();
                foreach (var cliente in clientes)
                {
                    Console.WriteLine(cliente.Nome);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            break;
        case "10":
            Console.WriteLine("Tem certeza que deseja sair? (1) Sim, (2) Não");
            var resp = Console.ReadLine();
            if(resp == "1")
            {
                programa = false;
            }           
            break;
        default:
            Console.WriteLine("Opção não encontrada, por favor, digite corretamente!");
            break;
    }

}
