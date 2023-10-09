using HhVacancyAnalyzerServer.Provider.Interfaces;
using HhVacancyAnalyzerServer.Provider.Services;
using Microsoft.Extensions.DependencyInjection;

namespace HhVacancyAnalyzerServer.Provider.Extensions;

public static class ServiceCollectionExtensions
{
    // TODO: think about name for method later
    public static void AddServices(this IServiceCollection services)
    {
        services.AddTransient<IItRolesHandlerService, ItRolesHandlerService>();
    }
}