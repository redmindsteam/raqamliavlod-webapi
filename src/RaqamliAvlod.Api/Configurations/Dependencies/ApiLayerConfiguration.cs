
using RaqamliAvlod.Infrastructure.Service.Interfaces.Common;
using RaqamliAvlod.Infrastructure.Service.Services.Common;

namespace RaqamliAvlod.Api.Configurations.Dependencies
{
    public static class ApiLayerConfiguration
    {
        public static void AddApiLayer(this WebApplicationBuilder builder)
        {
            builder.ConfigureLogger();
            builder.Services.ConfigureCorsPolicy();
            builder.Services.AddHttpContextAccessor();
            builder.Services.AddScoped<IPaginatorService, PaginatorServcie>();
        }
    }
}
