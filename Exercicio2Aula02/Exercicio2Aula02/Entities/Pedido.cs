using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2Aula02.Entities
{
    public class Pedido
    {
        private Guid _id;
        private DateTime _dataPedido;
        private string _valorPedido;
        private Cliente _cliente;

        public Guid Id
        {
            set { _id = value; }
            get { return _id; }
        }

        public DateTime DataPedido
        {
            set { _dataPedido = value; }
            get { return _dataPedido; }
        }
        public string ValorPedido
        {
            set { _valorPedido = value; }
            get { return _valorPedido; }
        }

        public Cliente Cliente
        {
            set { _cliente = value; }
            get { return _cliente; }
        }
    }
}

