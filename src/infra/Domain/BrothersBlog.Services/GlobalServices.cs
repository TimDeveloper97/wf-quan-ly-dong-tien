using BrothersBlog.Services.Interfaces;
using BrothersBlog.Services.Repositories;
using IO.Interfaces;
using IO.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace BrothersBlog.Services;

public class GlobalServices
{
    public static void Build(IServiceCollection serviceCollection)
    {
        // repository
        serviceCollection.AddSingleton(typeof(IJsonRepository<>), typeof(JsonRepository<>));
        serviceCollection.AddSingleton(typeof(IClassRepository), typeof(ClassRepository));
        //serviceCollection.AddSingleton(typeof(IClassManagerRepository), typeof(ClassManagerRepository));

        // service
        serviceCollection.AddScoped(typeof(IDatabaseService<>), typeof(DatabaseService<>));
        serviceCollection.AddScoped(typeof(IHomeService), typeof(HomeService));
    }
}
