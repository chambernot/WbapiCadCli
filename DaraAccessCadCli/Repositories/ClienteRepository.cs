using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DaraAccessCadCli.Connections.Interfaces;
using DomainCadCli;
using DomainCadCli.Collections;
using DomainCadCli.Interfaces.Repositories;
using MongoDB.Bson;
using MongoDB.Driver;

namespace DaraAccessCadCli.Collections
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly MongoDB.Driver. IMongoCollection<Cliente> _collection;

        public ClienteRepository(IMongoDbProvider dbProvider)
        {
            _collection = dbProvider.GetCollection<Cliente>("BDTeste", "Cliente");
        }

        public async Task DeleteCliente(Cliente cliente)
        {
            await _collection.DeleteOneAsync(x => x.Id.Equals(ObjectId.Parse(cliente.Id)));
        }

        public async Task<List<Cliente>> GetCliente()
        {
            var fields = Builders<Cliente>
                .Projection
                .Include(p => p.Id)
                .Include(p => p.DataCriacaoColecao)
                .Include(p => p.Cep)
                .Include(p => p.Cidade)
                .Include(p => p.Email)
                .Include(p => p.Estado)
                .Include(p => p.Estado)
                .Include(p => p.Logradouro)
                .Include(p => p.Nacionalidade)
                .Include(p => p.Nome)
                .Include(p => p.SobreNome)
                .Include(p => p.Telefone);
           return await _collection.Find(Builders<Cliente>.Filter.Empty).Project<Cliente>(fields).ToListAsync();
        }

        public async Task<List<Cliente>> GetClienteName(string nome)
        {
            var fields = Builders<Cliente>
                .Projection
                .Include(p => p.Id)
                .Include(p => p.DataCriacaoColecao)
                .Include(p => p.Cep)
                .Include(p => p.Cidade)
                .Include(p => p.Email)
                .Include(p => p.Estado)
                .Include(p => p.Estado)
                .Include(p => p.Logradouro)
                .Include(p => p.Nacionalidade)
                .Include(p => p.Nome)
                .Include(p => p.SobreNome)
                .Include(p => p.Telefone);

            Expression<Func<Cliente, bool>> filter = prop =>
               prop.Nome.ToUpper().Contains(nome.ToUpper());


            return await _collection.Find(filter).Project<Cliente>(fields).ToListAsync();
            
        }

        public async Task InsertCliente(Cliente cliente)
        {
            await _collection.InsertOneAsync(cliente);
        }

        public async Task ModifyCliente(Cliente cliente)
        {
            await _collection.ReplaceOneAsync(x => x.Id.Equals(ObjectId.Parse(cliente.Id)), cliente);
        }
    }
}
