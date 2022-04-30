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

        // This method gets called by the runtime. Use this method to add services to the container.  
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            var sqlConnectionString = "Host=localhost;Username=postgres;Password=admin123;Database=patients;SSLMode=Prefer";

            services.AddDbContext<PostgreSqlContext>(options => options.UseNpgsql(sqlConnectionString));

            services.AddScoped<IDataAccessProvider, DataAccessProvider>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.  
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
