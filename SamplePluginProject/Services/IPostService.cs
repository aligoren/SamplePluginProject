using SamplePluginProject.Models;

namespace SamplePluginProject.Services;

public interface IPostService
{
    void CreatePost(PostContent postContent);
}