﻿//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by YinChang.
// 4.2.1
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------

using System;
using System.Data;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Data.Common;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Data;

namespace FS.Cms.Posts
{
    public partial class PostTagMap : 
        Volo.Abp.Domain.Entities.Auditing.FullAuditedAggregateRoot<Guid>,
        Volo.Abp.MultiTenancy.IMultiTenant
    {

        public PostTagMap()
        {
            OnCreated();
        }

        public virtual System.Guid PostId
        {
            get;
            set;
        }

        public virtual System.Guid TagId
        {
            get;
            set;
        }

        public virtual System.Guid? TenantId
        {
            get;
            set;
        }


        #region Extensibility Method Definitions

        partial void OnCreated();

        #endregion
    }

}