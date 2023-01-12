using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Exercicio2Aula02.Entities
{
    public class Endereco
    {
        private Guid _id;
        private string _logradouro;
        private string _complemento;
        private string _cidade;
        private string _estado;
        private string _cep;
        private string _bairro;

        public Guid Id
        {
            set { _id = value; }
            get { return _id; }
        }

        public string Logradouro
        {
            set { _logradouro = value; }
            get { return _logradouro; }
        }
        public string Complemento
        {
            set { _complemento = value; }
            get { return _complemento; }
        }
        public string Cidade
        {
            set { _cidade = value; }
            get { return _cidade; }
        }
        public string Estado
        {
            set { _estado = value; }
            get { return _estado; }
        }
        public string Cep
        {
            set { _cep = value; }
            get { return _cep; }
        }
        public string Bairro
        {
            set { _bairro = value; }
            get { return _bairro; }
        }
    }
}
