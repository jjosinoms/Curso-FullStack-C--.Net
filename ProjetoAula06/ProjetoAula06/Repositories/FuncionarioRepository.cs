using Dapper;
using ProjetoAula06.Entities;
using ProjetoAula06.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAula06.Repositories
{
    public class FuncionarioRepository : IRepository<Funcionario>
    {
        private string _connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BDAula06;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public void Inserir(Funcionario obj)
        {

            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Execute("SP_INSERIR_FUNCIONARIO",
                    new
                    {
                        @P_IDFUNCIONARIO = obj.Id,
                        P_NOME = obj.Nome,
                        P_CPF = obj.Cpf,
                        P_DATAADMISSAO = obj.DataAdmissao,
                        P_TIPOCONTRATACAO = obj.TipoContratacao,
                        P_IDENDERECO = obj.Endereco.Id,
                        P_LOGRADOURO = obj.Endereco.Logradouro,
                        P_COMPLEMENTO = obj.Endereco.Complemento,
                        P_BAIRRO = obj.Endereco.Bairro,
                        P_CIDADE = obj.Endereco.Cidade,
                        P_ESTADO = obj.Endereco.Estado,
                        P_CEP = obj.Endereco.Cep,
                    },
                    commandType : CommandType.StoredProcedure
                    );
            }
        }
    }
}
