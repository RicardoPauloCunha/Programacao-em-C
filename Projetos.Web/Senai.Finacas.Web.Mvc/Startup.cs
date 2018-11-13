using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace Senai.Finacas.Web.Mvc
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //adiciona um sistema login em que o usario permancera um tempo no serve e depois de inativo o usuario será retirado da memoria
            services.AddDistributedMemoryCache();
            services.AddSession(
                options => options.IdleTimeout = TimeSpan.FromMinutes(10)
            );

            //adiciona o modelo mvc
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //usa o session
            app.UseSession();

            app.UseStaticFiles();
            
            //usa o mvc
            app.UseMvc(
                // define um rota pra iniciar a pagina/programa
                rota => rota.MapRoute(
                    name: "default",
                    template: "{controller=Usuario}/{action=Cadastrar}"
                )
            );
        }
    }
}
