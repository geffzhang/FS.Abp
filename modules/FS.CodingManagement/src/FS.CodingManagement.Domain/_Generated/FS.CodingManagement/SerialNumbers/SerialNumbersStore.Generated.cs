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
using Volo.Abp.Domain.Services;

namespace FS.CodingManagement.SerialNumbers
{
    public partial interface ISerialNumbersStore : IDomainService //auto-generated
    {
        ISerialNumberRepository SerialNumber { get; }
    }
}
