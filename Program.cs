using Dio.Series.Classes;
using Dio.Series.Infra;
using Dio.Series.Interfaces;
using Dio.Series.Repository;
using Dio.Series.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Dio.Series
{
    class Program
    {     
        static ServiceProvider RegistrarServices() {
            var services = new ServiceCollection();
            services.AddSingleton<IRepositorySerie, SerieRepository>();
            services.AddSingleton<IServiceSerie, ServiceSerie>();
            services.AddSingleton<Context>();
            services.AddTransient<Startup>();

            return services.BuildServiceProvider();
        }

        static void Main(string[] args)
        {
            using(ServiceProvider container = RegistrarServices()) 
            {
                var app = container.GetRequiredService<Startup>();
                app.Run();
            }

        }

    }            

}

