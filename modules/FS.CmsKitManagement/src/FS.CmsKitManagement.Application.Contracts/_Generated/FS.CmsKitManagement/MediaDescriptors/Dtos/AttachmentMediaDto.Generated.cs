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
using Volo.Abp.Application.Dtos;
using FS.Abp.Application.Dtos;

namespace FS.CmsKitManagement.MediaDescriptors.Dtos
{

    public partial class AttachmentMediaPrimaryKeyDto : EntityDto<Guid>
    {
    }

    public partial class AttachmentMediaDto : Volo.Abp.Application.Dtos.ExtensibleAuditedEntityDto<Guid>
    {
        public virtual string EntityType { get; set; }

        public virtual string EntityId { get; set; }

        public virtual System.Guid MediaDescriptorId { get; set; }

    }

    public partial class AttachmentMediaCreateDto : Volo.Abp.ObjectExtending.ExtensibleObject
    {
        public virtual string EntityType { get; set; }

        public virtual string EntityId { get; set; }

        public virtual System.Guid MediaDescriptorId { get; set; }

    }

    public partial class AttachmentMediaUpdateDto : Volo.Abp.ObjectExtending.ExtensibleObject
    {
        public virtual string EntityType { get; set; }

        public virtual string EntityId { get; set; }

        public virtual System.Guid MediaDescriptorId { get; set; }

    }

    public partial class AttachmentMediaGetListDto : SearchResultRequestDto
    {
    }

    public partial class AttachmentMediaWithDetailsDto : AttachmentMediaDto
    {
    }
}
