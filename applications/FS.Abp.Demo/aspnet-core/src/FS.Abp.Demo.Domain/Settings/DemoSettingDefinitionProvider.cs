﻿using Volo.Abp.Settings;

namespace FS.Abp.Demo.Settings
{
    public class DemoSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(DemoSettings.MySetting1));
        }
    }
}
