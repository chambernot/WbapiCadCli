using DomainCadCli.Collections;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DomainCadCli.Interfaces.Repositories
{
    public interface IClienteRepository
    {
        Task<List<Cliente>> GetClienteName(string nome);
        Task<List<Cliente>> GetCliente();

        Task<Cliente> InsertCliente(Cliente cliente );

        Task<Cliente> ModifyCliente(Cliente cliente);

        Task DeleteCliente(Cliente cliente);


    }
}
