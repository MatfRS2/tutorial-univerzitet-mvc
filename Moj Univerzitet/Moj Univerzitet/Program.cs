using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Moj_Univerzitet.Data;
using System;

namespace Moj_Univerzitet
{
    public class Program
    {

        private static void KreirajBazuAkoNijePostojala(IHost host)
        {
            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                try
                {
                    var context = services.GetRequiredService<MojUniverzitetKontekst>();
                    InicijalizacijaBazePodataka.Inicijalizuj(context);
                }
                catch (Exception ex)
                {
                    var logger = services.GetRequiredService<ILogger<Program>>();
                    logger.LogError(ex, "An error occurred creating the DB.");
                }
            }
        }
        public static void Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();

            KreirajBazuAkoNijePostojala(host);
            
            host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
