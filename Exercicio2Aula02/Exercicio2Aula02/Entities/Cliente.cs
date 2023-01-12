using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2Aula02.Entities
{
    public class Cliente
    {
        private Guid _id;
        private string _nome;
        private string _cpf;
        private string _telefone;
        private string _email;
        private Endereco _endereco;

        public Guid Id
        {
            set { _id = value; }
            get { return _id; }
        }

        public string Nome
        {
            set { _nome = value; }
            get { return _nome; }
        }

        public string Cpf
        {
            set { _cpf = value; }
            get { return _cpf; }
        }

        public string Telefone
        {
            set { _telefone = value; }
            get { return _telefone; }
        }

        public string Email
        {
            set { _email = value; }
            get { return _email; }
        }

        public Endereco Endereco
        {
            set { _endereco = value; }  
            get { return _endereco; }
        }
    }
}
