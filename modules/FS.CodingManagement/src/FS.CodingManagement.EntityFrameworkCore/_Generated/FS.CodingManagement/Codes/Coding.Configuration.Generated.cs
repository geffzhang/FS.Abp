﻿//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Entity Developer tool using EF Core template.
// 4.4.2
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
using FS.CodingManagement.EntityFrameworkCore;

namespace FS.CodingManagement.Codes
{
    public partial class CodingConfiguration : IEntityTypeConfiguration<Coding>
    {
        private CodingManagementModelBuilderConfigurationOptions options;
        public CodingConfiguration(CodingManagementModelBuilderConfigurationOptions options)
        {
            this.options = options;
        }
        public void Configure(EntityTypeBuilder<Coding> builder)
        {
            builder.ToTable(options.TablePrefix + @"Codings", options.Schema);
            builder.Property<Guid>(@"Id").HasColumnName(@"Id").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.No).HasColumnName(@"No").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.DisplayName).HasColumnName(@"DisplayName").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.Value).HasColumnName(@"Value").ValueGeneratedNever();
            builder.Property(x => x.Description).HasColumnName(@"Description").ValueGeneratedNever();
            builder.Property(x => x.Code).HasColumnName(@"Code").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.ParentId).HasColumnName(@"ParentId").ValueGeneratedNever();
            builder.Property(x => x.Level).HasColumnName(@"Level").ValueGeneratedNever();
            builder.Property(x => x.TenantId).HasColumnName(@"TenantId").ValueGeneratedNever();
            builder.HasKey(@"Id");
            builder.HasOne(x => x.Parent).WithMany(op => op.Children).IsRequired(false).HasForeignKey(@"ParentId");

            builder.ConfigureAuditedAggregateRoot();
            builder.HasIndex(x => x.CreationTime);

            CustomizeConfiguration(builder);
        }

        #region Partial Methods

        partial void CustomizeConfiguration(EntityTypeBuilder<Coding> builder);

        #endregion
    }

}
