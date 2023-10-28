using SamplePluginProject.Base.Infrastructure.EventHooks;

namespace SamplePluginProject.Base.Infrastructure.Interfaces;

public interface IPluginManager
{
    Hooks Hooks { get; }

    void AutoRegisterPlugins();
}