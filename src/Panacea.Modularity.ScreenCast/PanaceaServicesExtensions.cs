using Panacea.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panacea.Modularity.ScreenCast
{
    public static class PanaceaServicesExtensions
    {
        public static IScreenCastPlugin GetScreenCastPlugin(this PanaceaServices core)
        {
            return core.PluginLoader.GetPlugin<IScreenCastPlugin>();
        }
        public static bool TryGetScreenCast(this PanaceaServices core, out IScreenCastPlayer screencast)
        {
            screencast = core.PluginLoader.GetPlugins<IScreenCastPlugin>().FirstOrDefault()?.GetScreenCastPlayer();
            return screencast != null;
        }
    }
}
