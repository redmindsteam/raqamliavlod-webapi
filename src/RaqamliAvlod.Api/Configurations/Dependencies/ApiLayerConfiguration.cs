namespace RaqamliAvlod.Api.Configurations.Dependencies
{
    public static class ApiLayerConfiguration
    {
        public static void AddApiLayer(this WebApplicationBuilder builder)
        {
            builder.ConfigureLogger();
            builder.Services.ConfigureCorsPolicy();
        }
    }
}
