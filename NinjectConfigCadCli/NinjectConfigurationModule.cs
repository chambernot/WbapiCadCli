using DaraAccessCadCli.Collections;
using DaraAccessCadCli.Connections;
using DaraAccessCadCli.Connections.Interfaces;
using DomainCadCli.Interfaces.Repositories;
using Ninject.Modules;
using ServiceCadCli;
using ServiceCadCli.Interfaces;
using System;

namespace NinjectConfigCadCli
{
    public class NinjectConfigurationModule : NinjectModule
    {
        public override void Load()
        {
            // Connections
            Bind<IMongoDbProvider>().To<MongoDbProvider>().InSingletonScope();


            // Repositories
            Bind<IClienteRepository>().To<ClienteRepository>().InSingletonScope();

            // Services
            Bind<IClienteService>().To<ClienteService>().InSingletonScope();
        }
    }
}
