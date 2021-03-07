﻿//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by YinChang.
// 4.2.1
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
using FS.Cms.Documents.Dtos;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Application.Dtos;

namespace FS.Cms.Documents
{
    public partial class DocumentsApi //: IDocumentDefinitionCrudAppService //auto-generated 
    {
        [HttpGet]
        [Route("document-definition/id")]
        [NonAction][RemoteService(false)]
        public Task<DocumentDefinitionWithDetailsDto> GetAsync([FromQuery] DocumentDefinitionPrimaryKeyDto DocumentDefinitionPrimaryKey)
        {
            return this.DocumentDefinitionCrudAppService.GetAsync(DocumentDefinitionPrimaryKey);
        }

        [HttpGet]
        [Route("document-definition")]
        [RemoteService(true)]
        public Task<PagedResultDto<DocumentDefinitionWithDetailsDto>> GetListAsync(DocumentDefinitionGetListDto DocumentDefinitionGetList)
        {
            return this.DocumentDefinitionCrudAppService.GetListAsync(DocumentDefinitionGetList);
        }

        [HttpPost]
        [Route("document-definition")]
        [NonAction][RemoteService(false)]
        public Task<DocumentDefinitionWithDetailsDto> CreateAsync(DocumentDefinitionCreateDto DocumentDefinitionCreate)
        {
            return this.DocumentDefinitionCrudAppService.CreateAsync(DocumentDefinitionCreate);
        }

        [HttpPut]
        [Route("document-definition/id")]
        [NonAction][RemoteService(false)]
        public Task<DocumentDefinitionWithDetailsDto> UpdateAsync([FromQuery] DocumentDefinitionPrimaryKeyDto DocumentDefinitionPrimaryKey, DocumentDefinitionUpdateDto DocumentDefinitionUpdate)
        {
            return this.DocumentDefinitionCrudAppService.UpdateAsync(DocumentDefinitionPrimaryKey,DocumentDefinitionUpdate);
        }

        [HttpDelete]
        [Route("document-definition/id")]
        [NonAction][RemoteService(false)]
        public Task DeleteAsync([FromQuery] DocumentDefinitionPrimaryKeyDto DocumentDefinitionPrimaryKey)
        {
            return this.DocumentDefinitionCrudAppService.DeleteAsync(DocumentDefinitionPrimaryKey);
        }
    }
}