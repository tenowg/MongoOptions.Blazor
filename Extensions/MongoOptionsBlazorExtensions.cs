using Microsoft.Extensions.DependencyInjection;

namespace MongoOptions.Blazor.Extensions
{
    /// <summary>
    /// Extension methods for configuring MongoOptions Blazor services.
    /// </summary>
    public static class MongoOptionsBlazorExtensions
    {
        /// <summary>
        /// Adds MongoDB configuration UI services to the service collection.
        /// </summary>
        /// <param name="services">The service collection to add services to.</param>
        /// <returns>The updated service collection.</returns>
        public static IServiceCollection AddMongoConfigurationUI(this IServiceCollection services)
        {
            // This is a great place to register any UI-specific 
            // services or JS interop helpers you might add later
            return services;
        }
    }
}