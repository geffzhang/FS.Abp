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

namespace FS.FormManagement.Records.Dtos
{
    public partial class RecordItemAutoMapperProfile : Profile
    {
        public RecordItemAutoMapperProfile()
        {
            CreateMap<FS.FormManagement.Records.RecordItem, RecordItemDto>()
            .ReverseMap();
        
            CreateMap<RecordItemCreateDto, FS.FormManagement.Records.RecordItem>();
        
            CreateMap<RecordItemUpdateDto, FS.FormManagement.Records.RecordItem>();
        
            CreateMap<FS.FormManagement.Records.RecordItem, RecordItemWithDetailsDto>();
        
            CustomizeConfiguration();
        }
        partial void CustomizeConfiguration();
    }

}