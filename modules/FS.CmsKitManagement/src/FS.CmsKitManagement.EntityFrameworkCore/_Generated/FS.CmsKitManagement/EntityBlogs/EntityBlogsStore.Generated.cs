﻿//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by YinChang.
// 4.4.3
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Services;

namespace FS.CmsKitManagement.EntityBlogs
{
    public partial class EntityBlogsStore : DomainService, IEntityBlogsStore //auto-generated
    {
        public IEntityBlogRepository EntityBlog => this.LazyServiceProvider.LazyGetRequiredService<IEntityBlogRepository>();
    }
}