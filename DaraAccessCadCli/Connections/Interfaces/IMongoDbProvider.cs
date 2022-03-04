using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace DaraAccessCadCli.Connections.Interfaces
{
    public interface IMongoDbProvider
    {
        IMongoCollection<T> GetCollection<T>(string databaseName, string collectionName);
    }
}
