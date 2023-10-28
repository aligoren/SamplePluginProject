using SamplePluginProject.Base.Infrastructure.Enums;
using SamplePluginProject.Base.Infrastructure.EventBase;
using SamplePluginProject.Base.Infrastructure.EventHooks;
using SamplePluginProject.Base.Infrastructure.Interfaces;
using SamplePluginProject.Models;

namespace SamplePluginProject.Plugins;

public class MyFirstPlugin : IPlugin
{
    public void Initialize(Hooks hooks)
    {
        Console.WriteLine("MyFirstPlugin Initialized");
    }

    public Dictionary<PostEvents, Action<EventArgs>> SupportedActions => new()
    {
        { PostEvents.PostPublish, OnPublished }
    };

    private void OnPublished(EventArgs args)
    {
        if (args is PostEventArgs<PostContent> postArgs)
        {
            Console.WriteLine($"A post titled '{postArgs.PostData.Title}' has been published by MyFirstPlugin!");
        }
    }
}