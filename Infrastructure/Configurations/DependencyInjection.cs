using Domain.Repository;
using Infrastructure.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.Configurations;

public static class DependencyInjection
{
    // --------------------------------------------------------
    // I prefer that every part of solution manage your ow IoC
    // --------------------------------------------------------
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddDbContext<TodoContext>(opt => opt.UseInMemoryDatabase("Todos"));
        services.AddScoped<ITodoRepository, TodoRepository>();
        return services;
    }
}
