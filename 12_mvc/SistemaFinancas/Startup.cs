using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace SistemaFinancas
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {    
            services.AddDistributedMemoryCache();

            services.AddSession(
                options => options.IdleTimeout = TimeSpan.FromMinutes(30)
            );

            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSession();

            app.UseStaticFiles();

            app.UseMvc(
                rota => rota.MapRoute(
                    name: "default",
                    template: "{controller=Usuario}/{action=Cadastrar}"
                )
            );
        }
    }
}
