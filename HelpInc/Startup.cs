using Repository.Context;
using Domain.IRepository;
using Repository.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace HelpInc
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

            // DB Connection
            services.AddDbContext<HelpIncContext>(option =>
                option.UseLazyLoadingProxies().UseMySql(Configuration.GetConnectionString("db_HelpInc"), migration =>
                    migration.MigrationsAssembly("Repository")));

            // Identity
            services.AddIdentity<IdentityUser, IdentityRole>().AddEntityFrameworkStores<HelpIncContext>().AddDefaultTokenProviders();

            // Scope's
            services.AddScoped<IAddressRepository, AddressRepository>();
            services.AddScoped<ICompanyRepository, CompanyRepository>();
            services.AddScoped<IConsumerRepository, ConsumerRepository>();
            services.AddScoped<IGeolocalizationRepository, GeolocalizationRepository>();
            services.AddScoped<IGroupRepository, GroupRepository>();
            services.AddScoped<IGroupRoleRepository, GroupRoleRepository>();
            services.AddScoped<IProviderRepository, ProviderRepository>();
            services.AddScoped<ISkillRepository, SkillRepository>();
            services.AddScoped<ISkillLevelRepository, SkillLevelRepository>();
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

            app.UseAuthentication();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
