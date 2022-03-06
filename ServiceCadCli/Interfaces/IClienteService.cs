using DomainCadCli.Collections;
using ServiceCadCli.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ServiceCadCli.Interfaces
{
    public interface IClienteService
    {
        Task<Cliente> Insert(ClienteDTO cliente);

        Task<Cliente> Modify(ClienteDTO cliente);

        Task Delete(string id);

        Task<List<ClienteDTO>> Get();

        Task<List<ClienteDTO>> GetName(string nome);
    }
}
