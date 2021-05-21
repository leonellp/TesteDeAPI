using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using testedeapi.DA;
using testedeapi.Mapper;
using testedeapi.Business.Abstractions.Interfaces;
using testedeapi.Business;
using testedeapi.DA.Abstractions.interfaces;
using FluentValidation.AspNetCore;
using FluentValidation;
using testedeapi.Api.Abstractions.DTO;
using testedeapi.Validations;

namespace testedeapi.Api {
    public class Startup {

        readonly string MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

        public Startup(IConfiguration configuration) {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
                
        public void ConfigureServices(IServiceCollection services) {
            services.AddAutoMapper(typeof(Mappers));

            services.AddEntityFrameworkSqlServer().AddDbContext<testedeapiContext>(options => {
                options.UseSqlServer(Configuration.GetConnectionString("testedeapidb"));
            });

            services.AddControllers();
            services.AddControllersWithViews();
            services.AddRazorPages();

            services.AddSwaggerGen(options => {
                options.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo {
                    Title = "Teste de API C#",
                    Version = "v1",
                    Description = "Teste de contrução de API em C#",
                });
            });

            services.AddMvc()
                .AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<PacienteValidator>());

            services.AddScoped<IPacienteService, PacienteService>();
            services.AddScoped<IPacienteRepository, PacienteRepository>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env) {
            if (env.IsDevelopment()) {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseCors(MyAllowSpecificOrigins);

            app.UseEndpoints(endpoints => {
                endpoints.MapControllers();
            });

            app.UseSwagger();

            app.UseSwaggerUI(options => {
                options.SwaggerEndpoint("/swagger/v1/swagger.json", "Teste de API");
            });
        }
    }
}
