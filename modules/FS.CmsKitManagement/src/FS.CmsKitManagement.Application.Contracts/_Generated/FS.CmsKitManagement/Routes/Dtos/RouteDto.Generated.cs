﻿//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by YinChang.
// 4.3.0
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using Volo.Abp.Application.Dtos;
using FS.Abp.Application.Dtos;

namespace FS.CmsKitManagement.Routes.Dtos
{
    public partial class MetaData
    {
        public RoutePrimaryKeyDto RoutePrimaryKeyDto => new RoutePrimaryKeyDto();
        public RouteDto RouteDto => new RouteDto();
        public RouteCreateDto RouteCreateDto => new RouteCreateDto();
        public RouteUpdateDto RouteUpdateDto => new RouteUpdateDto();
        public RouteGetListDto RouteGetListDto => new RouteGetListDto();
        public RouteWithDetailsDto RouteWithDetailsDto => new RouteWithDetailsDto();
    }

    public partial class RoutePrimaryKeyDto : EntityDto<Guid>
    {
    }

    public partial class RouteDto : Volo.Abp.Application.Dtos.ExtensibleAuditedEntityDto<Guid>
    {
        public virtual string No { get; set; }

        public virtual string DisplayName { get; set; }

        public virtual System.Guid RouteDefinitionId { get; set; }

        public virtual string Code { get; set; }

        public virtual System.Guid? ParentId { get; set; }

        public virtual FS.CmsKitManagement.Routes.UrlType UrlType { get; set; }

        public virtual string Url { get; set; }

        public virtual int Level { get; set; }

        public virtual bool IsHidden { get; set; }

    }

    public partial class RouteCreateDto : Volo.Abp.ObjectExtending.ExtensibleObject
    {
        public virtual string No { get; set; }

        public virtual string DisplayName { get; set; }

        public virtual System.Guid RouteDefinitionId { get; set; }

        public virtual string Code { get; set; }

        public virtual System.Guid? ParentId { get; set; }

        public virtual FS.CmsKitManagement.Routes.UrlType UrlType { get; set; }

        public virtual string Url { get; set; }

        public virtual int Level { get; set; }

        public virtual bool IsHidden { get; set; }

    }

    public partial class RouteUpdateDto : Volo.Abp.ObjectExtending.ExtensibleObject
    {
        public virtual string No { get; set; }

        public virtual string DisplayName { get; set; }

        public virtual System.Guid RouteDefinitionId { get; set; }

        public virtual string Code { get; set; }

        public virtual System.Guid? ParentId { get; set; }

        public virtual FS.CmsKitManagement.Routes.UrlType UrlType { get; set; }

        public virtual string Url { get; set; }

        public virtual int Level { get; set; }

        public virtual bool IsHidden { get; set; }

    }

    public partial class RouteGetListDto : SearchResultRequestDto
    {
    }

    public partial class RouteWithDetailsDto : RouteDto
    {
        public RouteDefinitionDto RouteDefinition { get; set; }

        public List<RouteDto> Children { get; set; }

        public RouteDto Parent { get; set; }

    }
}