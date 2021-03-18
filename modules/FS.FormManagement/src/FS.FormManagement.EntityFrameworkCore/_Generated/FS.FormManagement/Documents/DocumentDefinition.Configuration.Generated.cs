﻿//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Entity Developer tool using EF Core template.
// 4.2.2
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
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Volo.Abp.EntityFrameworkCore.Modeling;
using FS.FormManagement.EntityFrameworkCore;

namespace FS.FormManagement.Documents
{
    public partial class DocumentDefinitionConfiguration : IEntityTypeConfiguration<DocumentDefinition>
    {
        private FormManagementModelBuilderConfigurationOptions options;
        public DocumentDefinitionConfiguration(FormManagementModelBuilderConfigurationOptions options)
        {
            this.options = options;
        }
        public void Configure(EntityTypeBuilder<DocumentDefinition> builder)
        {
            builder.ToTable(options.TablePrefix + @"DocumentDefinitions", options.Schema);
            builder.Property<Guid>(@"Id").HasColumnName(@"Id").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.No).HasColumnName(@"No").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.DisplayName).HasColumnName(@"DisplayName").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.CurrentVersionId).HasColumnName(@"CurrentVersionId").ValueGeneratedNever();
            builder.Property(x => x.TenantId).HasColumnName(@"TenantId").ValueGeneratedNever();
            builder.HasKey(@"Id");
            builder.HasOne(x => x.CurrentVersion).WithMany().IsRequired(false).HasForeignKey(@"CurrentVersionId");

            builder.ConfigureAuditedAggregateRoot();
            builder.HasIndex(x => x.CreationTime);

            CustomizeConfiguration(builder);
        }

        #region Partial Methods

        partial void CustomizeConfiguration(EntityTypeBuilder<DocumentDefinition> builder);

        #endregion
    }

}