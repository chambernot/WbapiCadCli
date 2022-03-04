using DaraAccessCadCli.Connections.Interfaces;
using DomainCadCli.Interfaces.Connections;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace DaraAccessCadCli.Connections
{
    public class MongoDbProvider : IMongoDbProvider
    {
        private readonly IMongoClient _mongoClient;
        public MongoDbProvider(IMongoDbProviderSettings settings)
        {
            _mongoClient = new MongoClient(settings.MongoDbConnectionString);
        }
            public IMongoCollection<TObject> GetCollection<TObject>(string databaseName, string collectionName)
        {
            return _mongoClient.GetDatabase(databaseName).GetCollection<TObject>(collectionName);
        }
    }
}
