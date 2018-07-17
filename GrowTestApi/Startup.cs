using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using GrowTestApi.Model;
using GrowTestApi.Services;
using GrowTestApi.Repositories;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace GrowTestApi
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
            services.AddScoped<IPolicyService, PolicyService>();
            services.AddScoped<IPolicyRepository, PolicyRepository>();
            services.AddScoped<IAgencyService, AgencyService>();
            services.AddScoped<IAgencyRepository, AgencyRepository>();
            services.AddScoped<IAuthenticationService, AuthencationService>();
            services.AddScoped<IAuthenticationRepository, AuthenticationRepository>();
            services.AddScoped<ICoverageService, CoverageService>();
            services.AddScoped<ICoverageRepository, CoverageRepository>();
            services.AddScoped<ICustomerService, CustomerService>();
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<IRiskService, RiskService>();
            services.AddScoped<IRiskRepository, RiskRepository>();
            services.AddDbContext<AuthenticationContext>(opt => opt.UseInMemoryDatabase("AuthenticationList"));
            services.AddDbContext<PolicyContext>(opt => opt.UseInMemoryDatabase("PolicyList"));
            services.AddDbContext<AgencyContext>(opt => opt.UseInMemoryDatabase("AgencyList"));
            services.AddDbContext<CoverageTypesContext>(opt => opt.UseInMemoryDatabase("CoverageList"));
            services.AddDbContext<CustomersContext>(opt => opt.UseInMemoryDatabase("CustomerList"));
            services.AddDbContext<RiskContext>(opt => opt.UseInMemoryDatabase("RiskList"));
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddCors();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
            app.UseCors(builder => builder.WithOrigins("*"));

        }
    }
}
