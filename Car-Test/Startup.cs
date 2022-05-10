using Car_Test.DataAcces;
using Microsoft.EntityFrameworkCore;

namespace Car_Test
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

       
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            var sqlConnectionString = "Host=localhost;Username=postgres;Password=admin123;Database=cars;SSLMode=Prefer";

            services.AddDbContext<PostgreSqlContext>(options => options.UseNpgsql(sqlConnectionString));

            services.AddScoped<IDataAccessProvider, DataAccessProvider>();
        }

       
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
