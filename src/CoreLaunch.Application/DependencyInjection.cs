using Microsoft.Extensions.DependencyInjection;
using FluentValidation;

namespace CoreLaunch.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        // Tüm FluentValidation sınıflarını otomatik bul ve ekle
        services.AddValidatorsFromAssembly(typeof(DependencyInjection).Assembly);
        
        // MediaTR'ı kullanabilmek için gerekli servisler
        services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(DependencyInjection).Assembly));

        return services;
    }
}
