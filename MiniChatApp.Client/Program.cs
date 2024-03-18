using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MiniChatApp.Client.Forms;
using MiniChatApp.Repositories.Contracts;
using MiniChatApp.Repositories.Repositories;

namespace MiniChatApp.Client
{
    internal static class Program
    {
        public static IServiceProvider ServiceProvider { get; private set; }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var host = CreateHostBuilder().Build();
            ServiceProvider = host.Services;

            Application.Run(ServiceProvider.GetRequiredService<LoginForm>());
        }

        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {
                    services.AddTransient<IAuthRepository, AuthRepository>();
                    services.AddTransient<LoginForm>();
                });
        }
    }
}