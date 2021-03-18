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

namespace FS.FormManagement.Forms
{
    public partial class ItemConfiguration : IEntityTypeConfiguration<Item>
    {
        private FormManagementModelBuilderConfigurationOptions options;
        public ItemConfiguration(FormManagementModelBuilderConfigurationOptions options)
        {
            this.options = options;
        }
        public void Configure(EntityTypeBuilder<Item> builder)
        {
            builder.ToTable(options.TablePrefix + @"Items", options.Schema);
            builder.Property<Guid>(@"Id").HasColumnName(@"Id").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.No).HasColumnName(@"No").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.Question).HasColumnName(@"Question").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.GroupId).HasColumnName(@"GroupId").ValueGeneratedNever();
            builder.Property(x => x.Sequence).HasColumnName(@"Sequence").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.TenantId).HasColumnName(@"TenantId").ValueGeneratedNever();
            builder.HasKey(@"Id");
            builder.HasOne(x => x.Group).WithMany(op => op.Items).IsRequired(true).HasForeignKey(@"GroupId");

            builder.ConfigureAuditedAggregateRoot();
            builder.HasIndex(x => x.CreationTime);

            CustomizeConfiguration(builder);
        }

        #region Partial Methods

        partial void CustomizeConfiguration(EntityTypeBuilder<Item> builder);

        #endregion
    }

}