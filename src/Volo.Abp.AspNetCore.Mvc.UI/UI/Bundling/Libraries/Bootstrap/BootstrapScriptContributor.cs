﻿using Volo.Abp.AspNetCore.Mvc.UI.Bundling.Libraries.JQuery;
using Volo.Abp.Modularity;

namespace Volo.Abp.AspNetCore.Mvc.UI.Bundling.Libraries.Bootstrap
{
    [DependsOn(typeof(JQueryScriptContributor))]
    public class BootstrapScriptContributor : BundleContributor
    {
        public override void ConfigureBundle(BundleConfigurationContext context)
        {
            context.Files.Add("/libs/bootstrap/js/bootstrap.bundle.js");
        }
    }
}