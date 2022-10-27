using Microsoft.EntityFrameworkCore;
using RaqamliAvlod.DataAccess.DbContexts;

namespace RaqamliAvlod.Api.Configurations.Dependencies
{
    public static class DataAccessLayerConfiguration
    {
        public static void AddDataAccessLayer(this WebApplicationBuilder builder)
        {
            string connectionString = builder.Configuration.GetConnectionString("HerokuProductionDb");
            builder.Services.AddDbContext<AppDbContext>(options =>
            {
                options.UseNpgsql(connectionString);
                options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
            });
        }
    }
}
