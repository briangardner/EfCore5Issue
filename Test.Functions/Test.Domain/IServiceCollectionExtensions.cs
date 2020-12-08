using Microsoft.Extensions.DependencyInjection;

namespace Test.Functions
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection AddSomeDependencies(this IServiceCollection serviceCollection)
        {
            return serviceCollection;
        }
    }
}
