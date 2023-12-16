using CompanyAPI.contexts;
using CompanyAPI.services;
using Microsoft.EntityFrameworkCore;

namespace CompanyAPI
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddSwaggerGen();
            services.AddSingleton<ICorporationCompanyGoalData, GoalCompanyGroupDataInMemory>();

            var connection = "server =localhost; database =CorporationDB; user = root; password =admin";
            services.AddDbContext<CorporationDbContext>(x => x.UseMySql(connection, ServerVersion.AutoDetect(connection)));
        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("./swagger/v1/swagger.json", "My API v1");
                    c.RoutePrefix = string.Empty;
                });
            }
            else
            {
                app.UseExceptionHandler(new ExceptionHandlerOptions
                {
                    ExceptionHandler = context => context.Response.WriteAsync("OOPS")
                });
            }
            app.UseStaticFiles();
            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
