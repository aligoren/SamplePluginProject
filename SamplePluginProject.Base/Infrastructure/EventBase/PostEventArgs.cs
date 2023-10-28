namespace SamplePluginProject.Base.Infrastructure.EventBase;

public class PostEventArgs<T> : EventArgs
{
    public T PostData { get; set; }
}