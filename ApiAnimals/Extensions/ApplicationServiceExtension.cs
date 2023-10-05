using AspNetCoreRateLimit;
using Core.Interfaces;
using Infrastructure.UnitOfWork;

namespace ApiAnimals.Extensions
{
    public static class ApplicationServiceExtension
    {

        public static void ConfigureCors(this IServiceCollection Services) =>
        Services.AddCors(options =>
        {
            options.AddPolicy(
                "CorsPolicy",
                builder =>
                builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader()
            );
        });

        public static void AddAplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
        }
        public static void ConfigureRateLimiting(this IServiceCollection Services)
        {
            Services.AddMemoryCache();
            Services.AddSingleton<IRateLimitConfiguration, RateLimitConfiguration>();
            Services.AddInMemoryRateLimiting();
            Services.Configure<IpRateLimitOptions>(options =>
            {
                options.EnableEndpointRateLimiting = true;
                options.StackBlockedRequests = false;
                options.HttpStatusCode = 429;
                options.RealIpHeader = "X-Rate-Limit";
                options.GeneralRules = new List<RateLimitRule>
                {
                    new RateLimitRule
                    {
                        Endpoint = "*",
                        Period = "10s",
                        Limit = 2
                    }
                };
            });
        }
    }
}