﻿using ProjetoAula05.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAula05.Interfaces
{
    public interface IClienteRepository
    {
        void Inserir(Cliente cliente);
        void MostrarClienteIndividual(Cliente cliente);
        void Deletar(Cliente cliente);
        void Alterar(Cliente cliente);
        List<Cliente> MostrarClientes();

    }
}
