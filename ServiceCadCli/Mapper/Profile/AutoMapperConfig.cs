using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceCadCli.Mapper.Profile
{
    public class AutoMapperConfig
    {
        public static void RegisterMappings()
        {
            AutoMapper.Mapper.Initialize(cfg =>
            {
                cfg.AddProfile(new DtoToDomainMappingProfile());
                cfg.AddProfile(new DomainToDtoMappingProfile());
            });
        }
    }
}
