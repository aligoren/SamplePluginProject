using SamplePluginProject.Base.Infrastructure.Enums;
using SamplePluginProject.Base.Infrastructure.EventHooks;

namespace SamplePluginProject.Base.Infrastructure.Interfaces;

public interface IPlugin
{
    void Initialize(Hooks hooks);
    Dictionary<PostEvents, Action<EventArgs>> SupportedActions { get; }
}