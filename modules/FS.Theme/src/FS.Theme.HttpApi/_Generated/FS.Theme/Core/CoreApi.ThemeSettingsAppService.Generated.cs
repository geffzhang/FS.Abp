﻿//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by YinChang.
// 4.2.1
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
using FS.FS.Theme.Core.Dtos;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Application.Dtos;

namespace FS.FS.Theme.Core
{
    public partial class CoreApi : IThemeSettingsAppService //auto-generated 
    {

        [HttpGet]
        [Route("theme-settings")]
        [NonAction][RemoteService(false)]
        public Task<ThemeSettingsDto> GetAsync(ThemeSettingsGetDto ThemeSettingsGet = null, bool fallback = true)
        {
            return ThemeSettingsAppService.GetAsync(ThemeSettingsGet);
        }

        [HttpPut]
        [Route("theme-settings")]
        [NonAction][RemoteService(false)]
        public Task UpdateAsync(ThemeSettingsDto ThemeSettings, string providerName = null, string providerKey = null)
        {
            return ThemeSettingsAppService.UpdateAsync(ThemeSettings, providerName, providerKey);
        }
    }
}