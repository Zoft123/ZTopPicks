using System;
using System.Collections.ObjectModel;
using MediaBrowser.Model.Plugins;

namespace Jellyfin.Plugin.ZTopPicks.Configuration
{

    public class PluginConfiguration : BasePluginConfiguration
{
    public Collection<Guid> TopMovieIds { get; } = new Collection<Guid>();

    public Collection<Guid> TopShowIds { get; } = new Collection<Guid>();

        // Optional: Initialize with defaults if needed later
    public PluginConfiguration()
        {
        }
    }
}
