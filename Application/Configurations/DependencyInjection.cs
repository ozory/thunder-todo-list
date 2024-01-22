using Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Application.Configurations;

public static class DependencyInjection
{
    // --------------------------------------------------------
    // I prefer that every part of solution manage your ow IoC
    // --------------------------------------------------------
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<ITodoService, TodoService>();
        return services;
    }
}
