using Application.Extensions;
using Infrastructure.Extensions;
using Presentation.Extensions;

namespace WebApi.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddLayers(this IServiceCollection services)
    {
        return services
            .AddPresentationLayer()
            .AddInfrastructureLayer()
            .AddApplicationLayer();
    }
}