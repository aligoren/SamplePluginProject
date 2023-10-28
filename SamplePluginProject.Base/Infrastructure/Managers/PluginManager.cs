using System.Reflection;
using SamplePluginProject.Base.Infrastructure.EventHooks;
using SamplePluginProject.Base.Infrastructure.Interfaces;

namespace SamplePluginProject.Base.Infrastructure.Managers;


public class PluginManager : IPluginManager
{
    private List<IPlugin> plugins { get; set; } = new();
    public Hooks Hooks { get; } = new Hooks();

    public PluginManager()
    {
        AutoRegisterPlugins();
    }

    private void RegisterPlugin(IPlugin plugin)
    {
        plugin.Initialize(Hooks);
        foreach (var actionPair in plugin.SupportedActions)
        {
            Hooks.RegisterAction(actionPair.Key, actionPair.Value);
        }
        plugins.Add(plugin);
    }

    public void AutoRegisterPlugins()
    {
        var currentAssembly = Assembly.GetEntryAssembly();
        foreach (var type in currentAssembly.GetTypes())
        {
            if (typeof(IPlugin).IsAssignableFrom(type) &&
                !type.IsInterface &&
                !type.IsAbstract &&
                !type.ContainsGenericParameters) // Generic parametre içermeyen sınıflar için kontrol eklendi
            {
                var pluginInstance = Activator.CreateInstance(type) as IPlugin;
                RegisterPlugin(pluginInstance);
            }
        }
    }
}