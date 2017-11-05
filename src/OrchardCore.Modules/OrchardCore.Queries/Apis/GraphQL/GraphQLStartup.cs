using Microsoft.Extensions.DependencyInjection;
using OrchardCore.Apis;
using OrchardCore.Modules;
using OrchardCore.Queries.Sql;

namespace OrchardCore.Queries.Apis.GraphQL
{
    public class GraphQLStartup : StartupBase
    {
        public override void ConfigureServices(IServiceCollection services)
        {
            services.AddGraphMutationType<CreateQueryMutation<SqlQuery>>();
            services.AddScoped<CreateQueryOutcomeType<SqlQuery>>();
        }
    }
}