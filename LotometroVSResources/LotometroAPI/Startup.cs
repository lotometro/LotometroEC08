using LotometroAPI.Interfaces;
using LotometroAPI.Models;
using LotometroAPI.Repository;
using LotometroAPI.Services;
using Microsoft.Extensions.Options;

namespace LotometroAPI
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
            // requires using Microsoft.Extensions.Options
            services.Configure<CameraDatabaseSettings>(
                Configuration.GetSection(nameof(CameraDatabaseSettings)));

            services.AddSingleton<ICameraDatabaseSettings>(sp =>
                sp.GetRequiredService<IOptions<ICameraDatabaseSettings>>().Value);

            //services.AddSingleton<CameraService>();
            services.AddTransient<ICameraService, CameraServiceRepository>();

            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
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
