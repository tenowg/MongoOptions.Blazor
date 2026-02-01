using Microsoft.Extensions.DependencyInjection;

namespace MongoOptions.Blazor.Extensions
{
    public static class MongoOptionsBlazorExtensions
    {
        public static IServiceCollection AddMongoConfigurationUI(this IServiceCollection services)
        {
            // This is a great place to register any UI-specific 
            // services or JS interop helpers you might add later
            return services;
        }
    }
}