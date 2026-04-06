using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using CoreLaunch.Application.Interfaces;

namespace CoreLaunch.Persistence;

public static class DependencyInjection
{
    public static IServiceCollection AddPersistenceServices(this IServiceCollection services, string connectionString)
    {
        services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlite(connectionString));

        services.AddScoped<IUnitOfWork, UnitOfWork>();

        return services;
    }
}
