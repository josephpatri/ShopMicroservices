using HealthChecks.UI.Client;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics.HealthChecks;
using Microsoft.Extensions.DependencyInjection;

namespace Shop.Common.HealthCheck;

public static class Extensions
{
    public static IServiceCollection AddHealthCheck(this IServiceCollection services, string mongoDbConnection, string apiName)
    {

        // Healcheck
        services.AddHealthChecks()
            .AddMongoDb(mongoDbConnection,
                        name: "mongodb",
                        timeout: TimeSpan.FromSeconds(5),
                        tags: new[] { "ready" });

        services.AddHealthChecksUI(opt =>
        {
            opt.SetEvaluationTimeInSeconds(15);
            opt.MaximumHistoryEntriesPerEndpoint(60);
            opt.SetApiMaxActiveRequests(2);
            opt.AddHealthCheckEndpoint(apiName, "/health");
        }).AddInMemoryStorage();

        return services;
    }
    public static WebApplication UseHealthCheck(this WebApplication app)
    {
        app.MapHealthChecks("/health", new HealthCheckOptions
        {
            Predicate = _ => true,
            ResponseWriter = UIResponseWriter.WriteHealthCheckUIResponse
        });

        app.MapHealthChecksUI();
        return app;
    }
}