﻿//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by YinChang.
// 4.4.0
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using Volo.Abp.Application.Dtos;

namespace FS.Settings.Dtos
{

    public partial class DemoSettingsGetDto
    {
        public virtual string ProviderName { get; set; }

        public virtual string ProviderKey { get; set; }

    }

    public partial class DemoSettingsDto
    {
        public virtual string Name { get; set; }

        public virtual string Title { get; set; }

        public virtual System.DateTime EndTime { get; set; }

        public virtual FS.Settings.Status Status { get; set; }

    }
}