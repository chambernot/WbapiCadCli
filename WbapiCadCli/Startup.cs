using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ServiceCadCli.Interfaces;
using ServiceCadCli;
using DaraAccessCadCli.Connections.Interfaces;
using DaraAccessCadCli.Connections;
using DomainCadCli.Interfaces.Repositories;
using DaraAccessCadCli.Collections;
using DomainCadCli.Interfaces.Connections;
using ServiceCadCli.Mapper.Profile;

namespace WbapiCadCli
{
    public class Startup
    {
        

        public Startup(IConfiguration configuration)
        {
           
            Configuration = configuration;
            AutoMapperConfig.RegisterMappings();

        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
   


            services.AddCors();
            
            // Connections
            services.AddTransient<IMongoDbProvider, MongoDbProvider>();
            
            
            // Repositories
            services.AddTransient<IClienteRepository, ClienteRepository>();

            

            services.AddTransient<IMongoDbProviderSettings, ClienteApiSettings>();
            // Services
            services.AddTransient<IClienteService, ClienteService>();

            services.AddMvc();
        }

        
        
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseCors(x => x
                .AllowAnyMethod()
                .AllowAnyHeader()
                .SetIsOriginAllowed(origin => true) // allow any origin
                .AllowCredentials());

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
            
        }
    }
}
