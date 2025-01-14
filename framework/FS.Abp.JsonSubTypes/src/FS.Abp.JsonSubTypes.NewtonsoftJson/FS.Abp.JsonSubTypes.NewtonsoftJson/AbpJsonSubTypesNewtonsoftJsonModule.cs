﻿using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System.Linq;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;
using JsonSubTypes;
using Volo.Abp.Json.SystemTextJson;

namespace FS.Abp.JsonSubTypes.NewtonsoftJson
{
    [DependsOn(typeof(FS.Abp.JsonSubTypes.JsonSubTypesModule))]
    [DependsOn(typeof(Volo.Abp.Json.AbpJsonModule))]
    [DependsOn(typeof(Volo.Abp.AspNetCore.AbpAspNetCoreModule))]
    public class AbpJsonSubTypesNewtonsoftJsonModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            var serviceProvider = context.Services.BuildServiceProvider();
            Configure<Microsoft.AspNetCore.Mvc.MvcNewtonsoftJsonOptions>(mvcNewtonsoftJsonOptions =>
            {
                var profiles = serviceProvider.GetServices<IJsonSubtypesConverterProfile>();
                profiles.ToList().ForEach(profile =>
                {
                    profile.JsonSubtypesConverterDefinitions.ForEach(definition =>
                    {
                        var item = JsonSubtypesConverterBuilder.Of(definition.BaseType, definition.DiscriminatorProperty).SetFallbackSubtype(definition.FallbackSubtype);
                        definition.Subtypes.ForEach(subtypeOption =>
                        {
                            item.RegisterSubtype(subtypeOption.Subtype, subtypeOption.value);
                        });

                        mvcNewtonsoftJsonOptions.SerializerSettings.Converters.Add(item.Build());
                    });
                });
            });

            Configure<AbpSystemTextJsonSerializerOptions>(abpSystemTextJsonSerializerOptions =>
            {
                var profiles = serviceProvider.GetServices<IJsonSubtypesConverterProfile>();
                profiles.ToList().ForEach(profile =>
                {
                    profile.JsonSubtypesConverterDefinitions.ForEach(definition =>
                    {
                        var item = JsonSubtypesConverterBuilder.Of(definition.BaseType, definition.DiscriminatorProperty).SetFallbackSubtype(definition.FallbackSubtype);
                        abpSystemTextJsonSerializerOptions.UnsupportedTypes.Add(definition.BaseType);
                    });
                });

            });
        }
    }
}
