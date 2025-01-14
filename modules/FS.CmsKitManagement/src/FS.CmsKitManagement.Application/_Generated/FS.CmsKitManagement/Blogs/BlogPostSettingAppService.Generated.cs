﻿//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Entity Developer tool using the template for generating AbpSettings.
// 4.4.2
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
using FS.CmsKitManagement.Blogs.Dtos;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace FS.CmsKitManagement.Blogs
{
    public partial class BlogPostSettingAppService : ApplicationService, IBlogPostSettingAppService // auto-generated
    {
        protected IBlogPostSettingFactory Factory => this.LazyServiceProvider.LazyGetRequiredService<IBlogPostSettingFactory>();

        public async Task<BlogPostSettingDto> GetAsync(BlogPostSettingGetDto BlogPostSettingGet = null, bool fallback = true)
        {
            BlogPostSettingDto result = new BlogPostSettingDto();
            return ObjectMapper.Map(await Factory.GetAsync(BlogPostSettingGet.ProviderName,BlogPostSettingGet.ProviderKey), result);
        }

        public async Task UpdateAsync(BlogPostSettingDto BlogPostSetting, string providerName = null, string providerKey = null)
        {
            var domain = new BlogPostSetting();

            ObjectMapper.Map(BlogPostSetting, domain);

            await Factory.SetAsync(domain, providerName, providerKey);

        }
    }
}
