using DomainCadCli.Collections;
using DomainCadCli.Interfaces.Repositories;
using ServiceCadCli.DTO;
using ServiceCadCli.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ServiceCadCli
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteService(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }
        public async Task Delete(string id)
        {
            ClienteDTO clienteDTO = new ClienteDTO();
            clienteDTO.Id = id;
            var clientemapper = AutoMapper.Mapper.Map<ClienteDTO, Cliente>(clienteDTO);
            await _clienteRepository.DeleteCliente(clientemapper);
        }

        

        public async Task<List<ClienteDTO>> GetName(string nome)
        {
           var retornocliente = await _clienteRepository.GetClienteName(nome);
           var clientemapper = AutoMapper.Mapper.Map<List<Cliente>, List<ClienteDTO>>(retornocliente);
           return clientemapper;
        }

        public async Task<Cliente> Insert(ClienteDTO cliente)
        {
            var clientemapper = AutoMapper.Mapper.Map<ClienteDTO, Cliente>(cliente);
            return await _clienteRepository.InsertCliente(clientemapper);
        }

        public async Task<Cliente> Modify(ClienteDTO cliente)
        {
            var clientemapper = AutoMapper.Mapper.Map<ClienteDTO, Cliente>(cliente);
            return await _clienteRepository.ModifyCliente(clientemapper);
        }

        public async Task<List<ClienteDTO>> Get()
        {
            var retornocliente = await _clienteRepository.GetCliente();
            var clientemapper = AutoMapper.Mapper.Map<List<Cliente>, List<ClienteDTO>>(retornocliente);
            return clientemapper;
        }
    }
}
