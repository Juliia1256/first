using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using CitiesAPI.Model;

namespace CitiesAPI
{
    public class Startup
    {

        public void ConfigureServices(IServiceCollection services)
        {
            //��������:
            //Singleton - 1 ������� �� ����������
            //Scoped - ������� ���� ���. �� ������������ ����� (�� ���� http ������)
            //Transient - ������� ��������� ��� ������ ���������
            services.AddSingleton<IStorage, Storage>();
            services.
                AddMvc(options => { options.RespectBrowserAcceptHeader = true; })
                .AddXmlSerializerFormatters();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>endpoints.MapControllers());
        }
    }
}
