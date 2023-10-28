using SamplePluginProject.Base.Infrastructure.Interfaces;
using SamplePluginProject.Base.Infrastructure.Managers;
using SamplePluginProject.Services;

namespace SamplePluginProject;

public static class DIExtensions
{
    public static void AddDependencies(this IServiceCollection services)
    {
        services.AddScoped<IPostService, PostService>();
    }
}