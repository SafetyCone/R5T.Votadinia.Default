using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;


namespace R5T.Votadinia.Default
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="CurrentUtcDateTimeProvider"/> implementation of <see cref="ICurrentUtcDateTimeProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddCurrentUtcDateTimeProvider(this IServiceCollection services)
        {
            services.AddSingleton<ICurrentUtcDateTimeProvider, CurrentUtcDateTimeProvider>();

            return services;
        }

        /// <summary>
        /// Adds the <see cref="CurrentUtcDateTimeProvider"/> implementation of <see cref="ICurrentUtcDateTimeProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<ICurrentUtcDateTimeProvider> AddCurrentUtcDateTimeProviderAction(this IServiceCollection services)
        {
            var serviceAction = ServiceAction.New<ICurrentUtcDateTimeProvider>(() => services.AddCurrentUtcDateTimeProvider());
            return serviceAction;
        }
    }
}
