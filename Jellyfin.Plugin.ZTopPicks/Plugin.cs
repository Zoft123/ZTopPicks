using System;
using System.Collections.Generic;
using Jellyfin.Plugin.ZTopPicks.Configuration;
using MediaBrowser.Common.Configuration;
using MediaBrowser.Common.Plugins;
using MediaBrowser.Model.Plugins;
using MediaBrowser.Model.Serialization;

namespace Jellyfin.Plugin.ZTopPicks
{
    public class Plugin : BasePlugin<PluginConfiguration>, IHasWebPages
    {
        public Plugin(IApplicationPaths applicationPaths, IXmlSerializer xmlSerializer)
            : base(applicationPaths, xmlSerializer)
        {
            Instance = this;
            SaveConfiguration();
        }

        public override string Name => "Zoft's Top Picks";

        public override Guid Id => Guid.Parse("45de9c0b-6c86-4709-9fc5-b69bac67535b");

        public static Plugin? Instance { get; private set; }

        public IEnumerable<PluginPageInfo> GetPages()
        {
            return new[]
            {
                new PluginPageInfo
                {
                    Name = Name,
                    EmbeddedResourcePath = $"{GetType().Namespace}.Configuration.configPage.html"
                }
            };
        }

        // No need to redeclare Configuration property; it's inherited from BasePlugin<T>
    }
}


