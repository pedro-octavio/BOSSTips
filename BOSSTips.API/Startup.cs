using Autofac;
using AutoMapper;
using BOSSTips.Application.Mappers;
using BOSSTips.Infra.Data;
using BOSSTips.Infra.IOC;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

namespace BOSSTips.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration) => Configuration = configuration;

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers().AddNewtonsoftJson();

            services.AddDbContext<DataContext>(opt => opt.UseMySql(Configuration["ConnectionStrings:BOSSTipsDB"], b => b.MigrationsAssembly("BOSSTips.API")));

            services.AddAutoMapper(typeof(MappingProfile));

            services.AddMediatR(AppDomain.CurrentDomain.Load("BOSSTips.Application"));

            services.AddSwaggerGen();
        }

        public void ConfigureContainer(ContainerBuilder builder) => builder.RegisterModule(new ModuleIOC());

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment()) app.UseDeveloperExceptionPage();

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseSwagger();

            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "BOSSTips"));

            app.UseEndpoints(endpoints => endpoints.MapControllers());
        }
    }
}
