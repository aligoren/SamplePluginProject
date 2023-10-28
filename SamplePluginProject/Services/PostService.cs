using SamplePluginProject.Base.Infrastructure.Enums;
using SamplePluginProject.Base.Infrastructure.EventBase;
using SamplePluginProject.Base.Infrastructure.Interfaces;
using SamplePluginProject.Models;

namespace SamplePluginProject.Services;

public class PostService : IPostService
{
    private readonly IPluginManager _plugin;

    public PostService(IPluginManager plugin)
    {
        _plugin = plugin;
    }

    public void CreatePost(PostContent postContent)
    {
        var postArgs = new PostEventArgs<PostContent>
        {
            PostData = postContent
        };
        _plugin.Hooks.DoAction(PostEvents.PostPublish, postArgs);
    }
}