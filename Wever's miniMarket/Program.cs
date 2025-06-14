using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Wever_s_miniMarket.CreacionEntidadesForms;
using Wever_s_miniMarket.PrincipalForms;
using Wever_s_miniMarket.Repository;
using Wever_s_miniMarket.Validators;

namespace Wever_s_miniMarket
{
    internal static class Program
    {
        
        [STAThread]
        static void Main()
        {

            IConfiguration configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();

            ServiceCollection services = new ServiceCollection();
            services.AddSingleton<IConfiguration>(configuration);
            services.AddTransient<Menufrm>();
            services.AddTransient<CategoryRepos>();
            services.AddTransient<CategoryValid>();
            services.AddTransient<CategoryFrm>();
            services.AddTransient<CategoryCrear>();

            services.AddTransient<ProductRepos>();
            services.AddTransient<ProductValid>();
            services.AddTransient<ProductFrm>();
            services.AddTransient<ProductCrear>();
            

            services.AddTransient<SupplierRepos>();
            services.AddTransient<SupplierValid>();
            services.AddTransient<SupplierFrm>();
            services.AddTransient<SupplierCrear>();
            var serviceProvider = services.BuildServiceProvider();


            ApplicationConfiguration.Initialize();

            var mainForm = serviceProvider.GetService<Menufrm>();
            Application.Run(mainForm);
        }
    }
}