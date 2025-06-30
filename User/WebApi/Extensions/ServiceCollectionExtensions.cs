using Infrastructure.Extensions;
using Presentation.Extensions;
using Application.Extensions;

namespace WebApi.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddLayers(this IServiceCollection services)
    {
        return services
            .AddPresentationLayer()
            .AddApplicationLayer()
            .AddInfrastructureLayer();
    }
}