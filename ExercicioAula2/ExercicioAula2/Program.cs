using ExercicioAula2.Entities;

var turma= new Turma();
turma.Professor = new Professor();
turma.Id = Guid.NewGuid();
turma.Professor.Id = Guid.NewGuid();


Console.Write("Insira o nome da Turma: ");
turma.Nome = Console.ReadLine();

Console.Write("Insira a Data de Início da Turma: ");
turma.DataInicio = DateTime.Parse(Console.ReadLine());

Console.Write("Insira o nome do Professor: ");
turma.Professor.Nome = Console.ReadLine();

Console.Write("Insira o Telefone do Professor: ");
turma.Professor.Telefone = Console.ReadLine();

Console.Write("Insira o CPF do Professor: ");
turma.Professor.Cpf = Console.ReadLine();


Console.WriteLine($"O id da Turma é: {turma.Id}");
Console.WriteLine($"O Nome da Truma é: {turma.Nome}");
Console.WriteLine($"O id do Professor é: {turma.Professor.Id}");
Console.WriteLine($"O Telefone do Professor é: {turma.Professor.Telefone}");
Console.WriteLine($"O CPF do Professor é: {turma.Professor.Cpf}");
Console.WriteLine($"O Nome do Professor é: {turma.Professor.Nome}");
