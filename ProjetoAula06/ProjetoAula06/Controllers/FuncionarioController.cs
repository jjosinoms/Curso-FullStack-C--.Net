using ProjetoAula06.Entities;
using ProjetoAula06.Enums;
using ProjetoAula06.Interfaces;
using ProjetoAula06.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAula06.Controllers
{
    public class FuncionarioController
    {

        public void CadastrarFuncionario()
        {
            var funcionario = new Funcionario();
            funcionario.Endereco = new Endereco();
            funcionario.Id = Guid.NewGuid();
            funcionario.Endereco.Id = Guid.NewGuid();
           

            try
            {
                Console.WriteLine("CADASTRO DE FUNCIONÁRIO__________");
                Console.Write("Digite o NOME do funcionário: ");
                funcionario.Nome = Console.ReadLine();
                Console.Write("Digite o CPF do funcionário: ");
                funcionario.Cpf = Console.ReadLine();
                Console.Write("Digite a Data de Admissão do funcionário: ");
                funcionario.DataAdmissao = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Digite o Tipo de Contratação do funcionário: ");
                Console.Write("1 - Estágio, 2 - CLT, 3 - Terceirizado: ");
                funcionario.TipoContratacao = (TipoContratacao)int.Parse(Console.ReadLine());
                Console.Write("Digite o Logradouro do funcionário: ");
                funcionario.Endereco.Logradouro = Console.ReadLine();
                Console.Write("Digite o Complemento do funcionário: ");
                funcionario.Endereco.Complemento = Console.ReadLine();
                Console.Write("Digite o Bairro do funcionário: ");
                funcionario.Endereco.Bairro = Console.ReadLine();
                Console.Write("Digite o Cidade do funcionário: ");
                funcionario.Endereco.Cidade = Console.ReadLine();
                Console.Write("Digite o Estado do funcionário: ");
                funcionario.Endereco.Estado = Console.ReadLine();
                Console.Write("Digite o CEP do funcionário: ");
                funcionario.Endereco.Cep = Console.ReadLine();

                #region Inserir no banco de dados

                var funcionarioRepository = new FuncionarioRepository();

                funcionarioRepository.Inserir(funcionario);

                Console.WriteLine("Funcionário cadastrado com Sucesso!");

                #endregion


            }
            catch (Exception e)
            {
                Console.WriteLine("Falha ao cadastrar!" + e.Message);
            }
        }

        public Funcionario AlterarFuncionario(Funcionario funcionario)
        {
            try
            {
                Console.WriteLine("ALTERAR FUNCIONÁRIO__________");
                Console.Write("Digite o NOME do funcionário: ");
                funcionario.Nome = Console.ReadLine();
                Console.Write("Digite o CPF do funcionário: ");
                funcionario.Cpf = Console.ReadLine();
                Console.Write("Digite a Data de Admissão do funcionário: ");
                funcionario.DataAdmissao = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Digite o Tipo de Contratação do funcionário: ");
                Console.Write("1 - Estágio, 2 - CLT, 3 - Terceirizado: ");
                funcionario.TipoContratacao = (TipoContratacao)int.Parse(Console.ReadLine());
                Console.Write("Digite o Logradouro do funcionário: ");
                funcionario.Endereco.Logradouro = Console.ReadLine();
                Console.Write("Digite o Complemento do funcionário: ");
                funcionario.Endereco.Complemento = Console.ReadLine();
                Console.Write("Digite o Bairro do funcionário: ");
                funcionario.Endereco.Bairro = Console.ReadLine();
                Console.Write("Digite o Cidade do funcionário: ");
                funcionario.Endereco.Cidade = Console.ReadLine();
                Console.Write("Digite o Estado do funcionário: ");
                funcionario.Endereco.Estado = Console.ReadLine();
                Console.Write("Digite o CEP do funcionário: ");
                funcionario.Endereco.Cep = Console.ReadLine();

            }
            catch(Exception e)
            {
                Console.WriteLine("Falha ao atualizar!" + e.Message);
            }

            return funcionario;

        }
    }
}
