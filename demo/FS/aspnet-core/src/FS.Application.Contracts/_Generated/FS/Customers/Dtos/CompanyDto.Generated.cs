﻿//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by YinChang.
// 4.3.0
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using Volo.Abp.Application.Dtos;
using FS.Abp.Application.Dtos;

namespace FS.Customers.Dtos
{
    public partial class MetaData
    {
        public CompanyDto CompanyDto => new CompanyDto();
        public CompanyCreateDto CompanyCreateDto => new CompanyCreateDto();
        public CompanyUpdateDto CompanyUpdateDto => new CompanyUpdateDto();
        public CompanyGetListDto CompanyGetListDto => new CompanyGetListDto();
        public CompanyWithDetailsDto CompanyWithDetailsDto => new CompanyWithDetailsDto();
    }

    public partial class CompanyDto : FS.Customers.Dtos.CustomerDto
    {
        public virtual string Address { get; set; }

    }

    public partial class CompanyCreateDto : FS.Customers.Dtos.CustomerCreateDto
    {
        public virtual string Address { get; set; }

    }

    public partial class CompanyUpdateDto : FS.Customers.Dtos.CustomerUpdateDto
    {
        public virtual string Address { get; set; }

    }

    public partial class CompanyGetListDto : FS.Customers.Dtos.CustomerGetListDto
    {
    }

    public partial class CompanyWithDetailsDto : FS.Customers.Dtos.CustomerWithDetailsDto
    {
        public virtual string Address { get; set; }

    }
}