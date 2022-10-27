namespace RaqamliAvlod.Api.Configurations
{
    public static class CorsPolicyConfiguration
    {
        public static void ConfigureCorsPolicy(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("AllowAll", builder =>
                    builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader()
                );
            });
        }
    }
}
