﻿//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by YinChang.
// 4.4.0
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
using System.Reflection;
using AutoMapper;
using Volo.Abp.AutoMapper;

namespace FS.Customers.Dtos
{
    public partial class PersonAutoMapperProfile : Profile
    {
        public PersonAutoMapperProfile()
        {
            CreateMap<FS.Customers.Person, PersonDto>()
            .ReverseMap();
        
            CreateMap<PersonCreateDto, FS.Customers.Person>();
        
            CreateMap<PersonUpdateDto, FS.Customers.Person>();
        
            CreateMap<FS.Customers.Person, PersonWithDetailsDto>();
        
            CustomizeConfiguration();
        }
        partial void CustomizeConfiguration();
    }

}
