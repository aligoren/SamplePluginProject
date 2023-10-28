using SamplePluginProject.Base.Infrastructure.Enums;
using SamplePluginProject.Base.Infrastructure.EventBase;

namespace SamplePluginProject.Base.Infrastructure.EventHooks;

public class Hooks
{
    private Dictionary<PostEvents, List<Action<EventArgs>>> actions = new();

    public void RegisterAction(PostEvents postEvent, Action<EventArgs> callback)
    {
        if (!actions.ContainsKey(postEvent))
            actions[postEvent] = new List<Action<EventArgs>>();

        actions[postEvent].Add(callback);
    }

    public void DoAction<T>(PostEvents postEvent, PostEventArgs<T> args)
    {
        if (actions.ContainsKey(postEvent))
            foreach (var action in actions[postEvent])
                action.Invoke(args);
    }
}