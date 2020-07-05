using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;

namespace L21_C02_empty_asp_net_core_app_final
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Host.CreateDefaultBuilder(args)
				.ConfigureWebHostDefaults(builder => builder.UseStartup<Startup>())
				.Build()
				.Run();
		}
	}

	public class Startup
	{
		public void Configure(IApplicationBuilder application)
		{
			application.UseRouting();
			application.UseEndpoints(endpoints =>
				endpoints.Map("/hello", context => context.Response.WriteAsync("<body><h1>Hello World</h1></body>"))
			);
		}
	}
}