﻿//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by YinChang.
// 4.2.2
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
using System.Reflection;
using AutoMapper;
using Volo.Abp.AutoMapper;

namespace FS.FormManagement.Documents.Dtos
{
    public partial class VersionAutoMapperProfile : Profile
    {
        public VersionAutoMapperProfile()
        {
            CreateMap<FS.FormManagement.Documents.Version, VersionDto>()
            .ReverseMap();
        
            CreateMap<VersionCreateDto, FS.FormManagement.Documents.Version>();
        
            CreateMap<VersionUpdateDto, FS.FormManagement.Documents.Version>();
        
            CreateMap<FS.FormManagement.Documents.Version, VersionWithDetailsDto>();
        
            CustomizeConfiguration();
        }
        partial void CustomizeConfiguration();
    }

}