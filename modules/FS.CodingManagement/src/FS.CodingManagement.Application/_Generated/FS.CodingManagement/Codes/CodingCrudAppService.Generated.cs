﻿//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by YinChang.
// 4.4.2
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

namespace FS.CodingManagement.Codes
{
    public partial class CodingCrudAppService :  // auto-generated
        Volo.Abp.Application.Services.CrudAppService<FS.CodingManagement.Codes.Coding, FS.CodingManagement.Codes.Dtos.CodingWithDetailsDto, Guid, FS.CodingManagement.Codes.Dtos.CodingGetListDto, FS.CodingManagement.Codes.Dtos.CodingCreateDto, FS.CodingManagement.Codes.Dtos.CodingUpdateDto>,
        ICodingCrudAppService
    {
        private readonly ICodingTreeRepository _repository;

        public CodingCrudAppService(ICodingTreeRepository repository) : base(repository)
        {
            this._repository = repository;
        }
    }
}