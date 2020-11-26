using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business;
using Business.Repositories;
using Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Models;

namespace API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Pomar", Version = "v1" });
            });

            services.AddScoped<DataContext, DataContext>();

            services.AddTransient<ArvoreRepository<Arvore>, ArvoreRepository<Arvore>>();
            services.AddTransient<ColheitaRepository<Colheita>, ColheitaRepository<Colheita>>();
            services.AddTransient<EspecieRepository<Especie>, EspecieRepository<Especie>>();
            services.AddTransient<GrupoArvoresRepository<GrupoArvores>, GrupoArvoresRepository<GrupoArvores>>();

            services.AddTransient<ArvoreBusiness<Arvore>, ArvoreBusiness<Arvore>>();
            services.AddTransient<ColheitaBusiness<Colheita>, ColheitaBusiness<Colheita>>();
            services.AddTransient<EspecieBusiness<Especie>, EspecieBusiness<Especie>>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.RoutePrefix = string.Empty;
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });


        }
    }
}
