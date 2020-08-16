using ControlAuvo.Business.Interfaces;
using ControlAuvo.Business.Interfaces.repositories;
using ControlAuvo.Business.Interfaces.services;
using ControlAuvo.Business.Notifications;
using ControlAuvo.Business.Services;
using ControlAuvo.Data.Context;
using ControlAuvo.Data.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace ControlAuvo.API.Configurations
{
    public static class DependencyInjection
    {
        public static void ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<ControlAuvoDbcontext>();

            services.AddScoped<INotifier, Notifier>();
            services.AddScoped<IRegistroService, RegistroService>();
            services.AddScoped<IRegistroRepository, RegistroRepository>();
        }
    }
}
