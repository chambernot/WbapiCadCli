using DomainCadCli.Interfaces.Connections;
using Microsoft.Extensions.Configuration;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WbapiCadCli
{
    public class ClienteApiNinjectModule : NinjectModule
    {
        public IConfiguration _Configuration { get; }
        public ClienteApiNinjectModule(IConfiguration configuration)
        {

            _Configuration = configuration;
        }
        public override void Load()
        {
            var settings = new ClienteApiSettings(_Configuration);
            Bind<IMongoDbProviderSettings>().ToConstant(settings);
        }
    }
}
