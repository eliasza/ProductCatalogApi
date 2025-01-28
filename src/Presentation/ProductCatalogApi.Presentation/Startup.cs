
using ProductCatalogApi.Application.Interfaces;
using ProductCatalogApi.Application.UseCases;
using ProductCatalogApi.Infrastructure.Repositories;

namespace ProductCatalogApi.Presentation
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            // Registrar repositório
            services.AddSingleton<IProductRepository, ProductRepository>();

            // Registrar casos de uso
            services.AddTransient<GetAllProducts>();
            services.AddTransient<GetProductById>();
            services.AddTransient<AddProduct>();
            services.AddTransient<UpdateProduct>();
            services.AddTransient<DeleteProduct>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
