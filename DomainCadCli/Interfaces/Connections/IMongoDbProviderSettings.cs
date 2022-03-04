using System;
using System.Collections.Generic;
using System.Text;

namespace DomainCadCli.Interfaces.Connections
{
    public interface IMongoDbProviderSettings
    {
        string MongoDbConnectionString { get; }
    }
}
