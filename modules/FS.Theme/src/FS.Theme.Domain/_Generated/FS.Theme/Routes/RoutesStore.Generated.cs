﻿//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by YinChang.
// 4.0.0
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Services;

namespace FS.Theme.Routes
{
    public partial interface IRoutesStore : IDomainService //auto-generated
    {
        IRouteDefinitionRepository RouteDefinition { get; }
        IRouteTreeRepository Route { get; }
    }
    public partial class RoutesStore : DomainService, IRoutesStore //auto-generated
    {
        public IRouteDefinitionRepository RouteDefinition => this.LazyServiceProvider.LazyGetRequiredService<IRouteDefinitionRepository>();
        public IRouteTreeRepository Route => this.LazyServiceProvider.LazyGetRequiredService<IRouteTreeRepository>();
    }
}