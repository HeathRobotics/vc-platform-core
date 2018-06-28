using System.Collections.Generic;
using VirtoCommerce.Platform.Core.Modularity;

namespace VirtoCommerce.ContentModule.Core
{
    public static class ContentConstants
    {
        public static class Security
        {
            public static class Permissions
            {
                public const string Read = "content:read",
                    Access = "content:access",
                    Create = "content:create",
                    Delete = "content:delete",
                    Update = "content:update";
            }

        }

        public static class Settings
        {
            public static class General
            {
                public static ModuleSetting CmsContentConnectionString = new ModuleSetting
                {
                    Name = "Content.CmsContentConnectionString",
                    ValueType = ModuleSetting.TypeString,
                    DefaultValue = @"provider=LocalStorage;rootPath=~\App_Data\cms-content"
                };

                public static IEnumerable<ModuleSetting> AllSettings
                {
                    get
                    {
                        yield return CmsContentConnectionString;
                    }
                }
            }
        }
    }
}
