﻿//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by YinChang.
// 4.4.2
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
using FS.CmsKitManagement.Routes.Dtos;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Application.Dtos;

namespace FS.CmsKitManagement.Routes
{
    public partial class RoutesApi //: IRouteCrudAppService //auto-generated 
    {
        [HttpGet]
        [Route("route/id")]
        [RemoteService(true)]
        public Task<RouteWithDetailsDto> GetAsync([FromQuery] RoutePrimaryKeyDto RoutePrimaryKey)
        {
            return this.RouteCrudAppService.GetAsync(RoutePrimaryKey);
        }

        [HttpGet]
        [Route("route")]
        [RemoteService(true)]
        public Task<PagedResultDto<RouteWithDetailsDto>> GetListAsync(RouteGetListDto RouteGetList)
        {
            return this.RouteCrudAppService.GetListAsync(RouteGetList);
        }

        [HttpPost]
        [Route("route")]
        [RemoteService(true)]
        public Task<RouteWithDetailsDto> CreateAsync(RouteCreateDto RouteCreate)
        {
            return this.RouteCrudAppService.CreateAsync(RouteCreate);
        }

        [HttpPut]
        [Route("route/id")]
        [RemoteService(true)]
        public Task<RouteWithDetailsDto> UpdateAsync([FromQuery] RoutePrimaryKeyDto RoutePrimaryKey, RouteUpdateDto RouteUpdate)
        {
            return this.RouteCrudAppService.UpdateAsync(RoutePrimaryKey,RouteUpdate);
        }

        [HttpDelete]
        [Route("route/id")]
        [RemoteService(true)]
        public Task DeleteAsync([FromQuery] RoutePrimaryKeyDto RoutePrimaryKey)
        {
            return this.RouteCrudAppService.DeleteAsync(RoutePrimaryKey);
        }
    }
}