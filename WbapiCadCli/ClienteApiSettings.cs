using DomainCadCli.Interfaces.Connections;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WbapiCadCli
{
    public class ClienteApiSettings : IMongoDbProviderSettings
    {
        public string MongoDbConnectionString { get; }
        

        
        public ClienteApiSettings(IConfiguration configuration)
        {
            MongoDbConnectionString = configuration.GetSection("MySettings").GetSection("ConnectionStringId").Value;
             
        }

    }
}
