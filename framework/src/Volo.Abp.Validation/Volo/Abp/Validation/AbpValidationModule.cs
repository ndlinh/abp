﻿using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace Volo.Abp.Validation
{
    public class AbpValidationModule : AbpModule
    {
        public override void PreConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.OnRegistred(ValidationInterceptorRegistrar.RegisterIfNeeded);
        }

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpValidationOptions>(options =>
            {
                options.ObjectValidationContributors.Add<ObjectValidator>();
                options.ObjectValidationContributors.Add<DataAnnotationValidator>();
            });
        }
    }
}
