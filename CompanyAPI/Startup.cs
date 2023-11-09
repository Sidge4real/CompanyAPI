using CompanyAPI.services;

namespace CompanyAPI
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<ICompanyData, CompanyData>();
            services.AddSingleton<ICompanyGroupData, CompanyGroupData>();
            services.AddSingleton<IGoalData, GoalData>();
            services.AddControllers();
        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseStaticFiles();
            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                //endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}");
            });
        }
    }
}
