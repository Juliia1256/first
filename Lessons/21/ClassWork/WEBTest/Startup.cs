using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace CitiesAPI
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints => endpoints.MapControllers());
        }
    }
    [Route("/api/cities")]
    public class CityController : ControllerBase
    {
        
            private List<City> _items = new List<City>
            {
                new City("Moscow", DateTimeOffset.Parse("1147.02.03"), 16000000),
                new City("Saint Petersburg", DateTimeOffset.Parse("1300.02.03"), 4000000)
            };
        [HttpGet]
        public IActionResult List()
        {
            return Ok(_items);
        }
    }
    public class City
    {
        public City(string title, DateTimeOffset dateTime, int population)
        {
            Id = Guid.NewGuid();
            Title = title;
            DateTime = dateTime;
            Population = population;
        }

        public Guid Id { get; set; }
        public string Title { get; set; }
        public DateTimeOffset DateTime { get; set; }
        public int Population { get; set; }
    }
}
