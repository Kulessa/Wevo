using Microsoft.Extensions.DependencyInjection;
using WevoCristianRichardKulessa.Application.Services;
using WevoCristianRichardKulessa.Application.Services.Interfaces;
using WevoCristianRichardKulessa.Domain.Repositories.Interfaces;
using WevoCristianRichardKulessa.Domain.Services;
using WevoCristianRichardKulessa.Domain.Services.Interfaces;
using WevoCristianRichardKulessa.Infrastructure.Data.Repositories;

namespace WevoCristianRichardKulessa.Infrastructure.IOC
{
    public static class Container
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            //services.AddSingleton<I, C>(); 
            //services.AddTransient<I, C>();
            //services.AddScoped<I, C>();

            services.AddScoped<IUsuarioRepository, UsuarioRepository>();
            services.AddScoped<IUsuarioService, UsuarioService>();
            services.AddScoped<IUsuarioAppService, UsuarioAppService>();
        }
    }
}