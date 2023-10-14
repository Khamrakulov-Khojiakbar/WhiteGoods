using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Technics;

public static class Services
{
    public static IServiceCollection AddDbContexts(
        this IServiceCollection services
        , IConfiguration configuration)
    {
        var connectionsString = "Host=localhost;Port=5432;Database=WhiteGoodsTest;Username=postgres;Password=1221;";

        services.AddDbContextPool<AppDbContext>(options =>
        {
            options.UseNpgsql(connectionsString);
        });

        return services;
    }
}
