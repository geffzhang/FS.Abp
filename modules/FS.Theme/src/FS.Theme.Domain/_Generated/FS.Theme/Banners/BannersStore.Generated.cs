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

namespace FS.Theme.Banners
{
    public partial interface IBannersStore : IDomainService //auto-generated
    {
        IBannerDefinitionRepository BannerDefinition { get; }
        IBannerRepository Banner { get; }
    }
    public partial class BannersStore : DomainService, IBannersStore //auto-generated
    {
        public IBannerDefinitionRepository BannerDefinition => this.LazyServiceProvider.LazyGetRequiredService<IBannerDefinitionRepository>();
        public IBannerRepository Banner => this.LazyServiceProvider.LazyGetRequiredService<IBannerRepository>();
    }
}