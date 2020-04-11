namespace EasyHealth.Server.Repositories
{
    using Microsoft.Extensions.DependencyInjection;

    public class RegisterService
    {
        public RegisterService(ref IServiceCollection services)
        {
            services.AddScoped<IServices.IServiceSupplyCategory, Services.ServiceSupplyCategory>();
        }
    }
}
