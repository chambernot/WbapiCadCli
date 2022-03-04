using DomainCadCli.Collections;
using ServiceCadCli.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;

namespace ServiceCadCli.Mapper.Profile
{
    public class DtoToDomainMappingProfile : AutoMapper.Profile
    {
        public DtoToDomainMappingProfile()
        {
            CreateMap<ClienteDTO, Cliente>()
                .ForMember(m => m.Id, map => map.MapFrom(vm => vm.Id.TrimEnd()))
                .ForMember(m => m.Cep, map => map.MapFrom(vm => vm.Cep.TrimEnd()))
                 .ForMember(m => m.Cidade, map => map.MapFrom(vm => vm.Cidade.TrimEnd()))
                 .ForMember(m => m.Email, map => map.MapFrom(vm => vm.Email))
                 .ForMember(m => m.Estado, map => map.MapFrom(vm => vm.Estado.TrimEnd()))
                 .ForMember(m => m.Logradouro, map => map.MapFrom(vm => vm.Logradouro.TrimEnd()))
                 .ForMember(m => m.Nacionalidade, map => map.MapFrom(vm => vm.Nacionalidade.TrimEnd()))
                 .ForMember(m => m.Nome, map => map.MapFrom(vm => vm.Nome.TrimEnd()))
                 .ForMember(m => m.SobreNome, map => map.MapFrom(vm => vm.SobreNome.TrimEnd()))
                 .ForMember(m => m.Telefone, map => map.MapFrom(vm => vm.Telefone.TrimEnd()))
                 ;

        }

    }
}
