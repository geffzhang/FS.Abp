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
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace FS.CmsKitManagement.EntityBlogs
{
    public partial class EntityBlogCrudAppService :  // auto-generated
        FS.Abp.Application.Services.EntityWithKeyCrudAppService<FS.CmsKitManagement.EntityBlogs.EntityBlog, FS.CmsKitManagement.EntityBlogs.Dtos.EntityBlogWithDetailsDto, FS.CmsKitManagement.EntityBlogs.Dtos.EntityBlogPrimaryKeyDto, Guid, FS.CmsKitManagement.EntityBlogs.Dtos.EntityBlogGetListDto, FS.CmsKitManagement.EntityBlogs.Dtos.EntityBlogCreateDto, FS.CmsKitManagement.EntityBlogs.Dtos.EntityBlogUpdateDto>,
        IEntityBlogCrudAppService
    {
        private readonly IEntityBlogRepository _repository;

        public EntityBlogCrudAppService(IEntityBlogRepository repository) : base(repository)
        {
            this._repository = repository;
        }
    }
}