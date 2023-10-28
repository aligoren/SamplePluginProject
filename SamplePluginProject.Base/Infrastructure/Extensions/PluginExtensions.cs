using Microsoft.Extensions.DependencyInjection;
using SamplePluginProject.Base.Infrastructure.Interfaces;
using SamplePluginProject.Base.Infrastructure.Managers;

namespace SamplePluginProject.Base.Infrastructure.Extensions;

public static class PluginExtensions
{
    public static void RegisterPlugins(this IServiceCollection services)
    {
        services.AddScoped<IPluginManager, PluginManager>();
    }
}