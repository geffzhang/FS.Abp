﻿//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by YinChang.
// 4.4.2
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
using FS.CmsKitManagement.Blogs.Dtos;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Application.Dtos;

namespace FS.CmsKitManagement.Blogs
{
    public partial class BlogsApi : IBlogPostSettingAppService //auto-generated 
    {

        [HttpGet]
        [Route("blog-post-setting")]
        [RemoteService(true)]
        public Task<BlogPostSettingDto> GetAsync(BlogPostSettingGetDto BlogPostSettingGet, bool fallback = true)
        {
            return BlogPostSettingAppService.GetAsync(BlogPostSettingGet);
        }

        [HttpPut]
        [Route("blog-post-setting")]
        [NonAction][RemoteService(false)]
        public Task UpdateAsync(BlogPostSettingDto BlogPostSetting, string providerName = null, string providerKey = null)
        {
            return BlogPostSettingAppService.UpdateAsync(BlogPostSetting, providerName, providerKey);
        }
    }
}
