﻿//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Entity Developer tool using the template for generating AbpSettings.
// 4.4.0
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
using FS.Settings.Dtos;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace FS.Settings
{
    public partial class DemoSettingsAppService : ApplicationService, IDemoSettingsAppService // auto-generated
    {
        protected IDemoSettingsFactory Factory => this.LazyServiceProvider.LazyGetRequiredService<IDemoSettingsFactory>();

        public async Task<DemoSettingsDto> GetAsync(DemoSettingsGetDto DemoSettingsGet = null, bool fallback = true)
        {
            DemoSettingsDto result = new DemoSettingsDto();
            return ObjectMapper.Map(await Factory.GetAsync(DemoSettingsGet.ProviderName,DemoSettingsGet.ProviderKey), result);
        }

        public async Task UpdateAsync(DemoSettingsDto DemoSettings, string providerName = null, string providerKey = null)
        {
            var domain = new DemoSettings();

            ObjectMapper.Map(DemoSettings, domain);

            await Factory.SetAsync(domain, providerName, providerKey);

        }
    }
}
