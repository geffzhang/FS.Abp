﻿//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Entity Developer tool using EF Core template.
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
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Volo.Abp.EntityFrameworkCore.Modeling;
using FS.Cms.EntityFrameworkCore;

namespace FS.Cms.Posts
{
    public partial class PostConfiguration : IEntityTypeConfiguration<Post>
    {
        private CmsModelBuilderConfigurationOptions options;
        public PostConfiguration(CmsModelBuilderConfigurationOptions options)
        {
            this.options = options;
        }
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.ToTable(options.TablePrefix + @"Posts", options.Schema);
            builder.Property<Guid>(@"Id").HasColumnName(@"Id").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.BlogId).HasColumnName(@"BlogId").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.Title).HasColumnName(@"Title").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.Subtitle).HasColumnName(@"Subtitle").ValueGeneratedNever();
            builder.Property(x => x.Url).HasColumnName(@"Url").ValueGeneratedNever();
            builder.Property(x => x.Content).HasColumnName(@"Content").ValueGeneratedNever();
            builder.Property(x => x.Disable).HasColumnName(@"Disable").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.StartTime).HasColumnName(@"StartTime").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.EndTime).HasColumnName(@"EndTime").ValueGeneratedNever();
            builder.Property(x => x.DisplayMode).HasColumnName(@"DisplayMode").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.Sequence).HasColumnName(@"Sequence").IsRequired().ValueGeneratedNever();
            builder.Ignore(x => x.AttachmentFileUrls);
            builder.Ignore(x => x.PostImages);
            builder.Property(x => x.TenantId).HasColumnName(@"TenantId").ValueGeneratedNever();
            builder.HasKey(@"Id");

            builder.ConfigureFullAuditedAggregateRoot();
            builder.HasIndex(x => x.CreationTime);

            CustomizeConfiguration(builder);
        }

        #region Partial Methods

        partial void CustomizeConfiguration(EntityTypeBuilder<Post> builder);

        #endregion
    }

}