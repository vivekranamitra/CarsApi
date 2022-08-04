using CarsApi.Domain.Repositories;

namespace CarsApi.Service.Extensions;
public static class ServiceExtensions
{
    public static void RegisterRepos(this IServiceCollection collection)
    {
        collection.AddTransient<ICarRepository, CarRepository>();
        collection.AddEntityFrameworkSqlServer();
    }
}
