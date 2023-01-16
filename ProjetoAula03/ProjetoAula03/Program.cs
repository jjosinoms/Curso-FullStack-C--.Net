using ProjetoAula03.Entities;

var profissional = new Profissional();
profissional.Servicos = new List<Servico>();

profissional.Id = Guid.NewGuid();

Console.WriteLine("Cadastro de Profissional!");
Console.WriteLine("Digite o nome do Profissional!");
profissional.Nome = Console.ReadLine();
Console.WriteLine("Digite a Matrícula do Profissional!");
profissional.Matricula = Console.ReadLine();
Console.WriteLine("Digite o CPF do Profissional!");
profissional.Cpf = Console.ReadLine();
Console.WriteLine("Digite o Telefone do Profissional!");
profissional.Telefone = Console.ReadLine();

Console.WriteLine("Cadastro de Profissional!");
Console.Write("Quantos servicos voce deseja adicionar?");
var quantServicos = int.Parse(Console.ReadLine());


for (int i = 0; i < quantServicos; i++)
{
    var servico = new Servico();
    servico.Id = Guid.NewGuid();

    Console.WriteLine($"Digite o nome do {i+1}º Servico");
    servico.Nome = Console.ReadLine();

    Console.WriteLine($"Digite o Valor do { i+1 }º Servico");
    servico.Valor = decimal.Parse(Console.ReadLine());

    profissional.Servicos.Add(servico);
}

Console.WriteLine("DETALHE DO PROFISSIONAL:___________________________");
Console.WriteLine("Nome: " + profissional.Nome);
Console.WriteLine("CPF: " + profissional.Cpf);
Console.WriteLine("Matrícula: " + profissional.Matricula);
Console.WriteLine("Telefone: " + profissional.Telefone);

Console.WriteLine("DETALHES DOS SERVIÇOS:___________________________");
foreach (var item in profissional.Servicos)
{
    Console.WriteLine("ID do Serviço: " + item.Id);
    Console.WriteLine("Nome do Serviço: " + item.Nome);
    Console.WriteLine("Valor do Serviço: R$ " + item.Valor);
}