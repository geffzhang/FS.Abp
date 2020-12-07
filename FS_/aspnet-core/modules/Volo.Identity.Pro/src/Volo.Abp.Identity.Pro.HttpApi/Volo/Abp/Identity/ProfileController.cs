﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc;

namespace Volo.Abp.Identity
{
    [RemoteService(Name = IdentityProRemoteServiceConsts.RemoteServiceName)]
    [Area("identity")]
    [ControllerName("Profile")]
    [Route("/api/identity/my-profile")]
    public class ProfileController : AbpController, IProfileAppService
    {
        protected IProfileAppService ProfileAppService { get; }

        public ProfileController(IProfileAppService profileAppService)
        {
            ProfileAppService = profileAppService;
        }

        [HttpGet]
        public virtual Task<ProfileDto> GetAsync()
        {
            return ProfileAppService.GetAsync();
        }

        [HttpPut]
        public virtual Task<ProfileDto> UpdateAsync(UpdateProfileDto input)
        {
            return ProfileAppService.UpdateAsync(input);
        }

        [HttpPost]
        [Route("change-password")]
        public virtual Task ChangePasswordAsync(ChangePasswordInput input)
        {
            return ProfileAppService.ChangePasswordAsync(input);
        }

        [HttpGet]
        [Route("two-factor-enabled")]
        public Task<bool> GetTwoFactorEnabledAsync()
        {
            return ProfileAppService.GetTwoFactorEnabledAsync();
        }

        [HttpPost]
        [Route("set-two-factor-enabled")]
        public Task SetTwoFactorEnabledAsync(bool enabled)
        {
            return ProfileAppService.SetTwoFactorEnabledAsync(enabled);
        }
    }
}