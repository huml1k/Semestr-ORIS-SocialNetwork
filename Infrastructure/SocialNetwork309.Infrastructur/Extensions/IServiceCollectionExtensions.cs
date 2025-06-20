using Microsoft.Extensions.DependencyInjection;
using SocialNetwork309.Application.Common;
using SocialNetwork309.Application.Interfaces.Repositories;
using SocialNetwork309.Application.Interfaces.Services;
using SocialNetwork309.Application.Repositories;
using SocialNetwork309.Infrastructur.Services;
using SocialNetwork309.Persistence.Repositories;

namespace SocialNetwork309.Infrastructur.Extensions
{
    public static class IServiceCollectionExtensions
    {
        public static void AddInfrastructureLayer(this IServiceCollection services)
        {
            services.AddServices();
            services.AddRepositories();
        }

        private static void AddRepositories(this IServiceCollection services)
        {
            services
                .AddTransient(typeof(IUnitOfWork), typeof(UnitOfWork))
                .AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>))
                .AddTransient<IPostRepository, PostRepository>();
        }

        private static void AddServices(this IServiceCollection services)
        {
            services.AddTransient<IAuthService, AuthService>();
        }
    }
}
