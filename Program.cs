using InjecaoDependenciaWinForms.Services;
using Microsoft.Extensions.DependencyInjection;

namespace InjecaoDependenciaWinForms
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            // Configurar servi�os
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);

            // Construir o provedor de servi�os
            var serviceProvider = serviceCollection.BuildServiceProvider();

            // Iniciar a aplica��o com o formul�rio principal
            var formPrincipal = serviceProvider.GetRequiredService<Form1>();
            Application.Run(formPrincipal);
        }
        private static void ConfigureServices(IServiceCollection services)
        {
            // Registrar formul�rios e servi�os
            services.AddScoped<Form1>();
            // Exemplo: services.AddTransient<IMeuServico, MeuServico>();
            services.AddScoped<IMessageService, MessageService>();
        }
    }
}