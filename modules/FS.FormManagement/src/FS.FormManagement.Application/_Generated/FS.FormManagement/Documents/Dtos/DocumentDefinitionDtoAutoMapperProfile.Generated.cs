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
    public partial class DocumentDefinitionAutoMapperProfile : Profile
    {
        public DocumentDefinitionAutoMapperProfile()
        {
            CreateMap<FS.FormManagement.Documents.DocumentDefinition, DocumentDefinitionDto>()
            .ReverseMap();
        
            CreateMap<DocumentDefinitionCreateDto, FS.FormManagement.Documents.DocumentDefinition>();
        
            CreateMap<DocumentDefinitionUpdateDto, FS.FormManagement.Documents.DocumentDefinition>();
        
            CreateMap<FS.FormManagement.Documents.DocumentDefinition, DocumentDefinitionWithDetailsDto>();
        
            CustomizeConfiguration();
        }
        partial void CustomizeConfiguration();
    }

}