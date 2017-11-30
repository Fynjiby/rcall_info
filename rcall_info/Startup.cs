using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace rcall_info
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
	    services.AddMvc();
	}

	// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
	public void Configure(IApplicationBuilder app, IHostingEnvironment env)
	{
	    if (env.IsDevelopment())
	    {
			app.UseDeveloperExceptionPage();
			app.UseBrowserLink();
			app.UseWebpackDevMiddleware();
	    }
	    else
	    {
			app.UseExceptionHandler("/Home/Error");
	    }

	    app.UseStaticFiles();

	    app.UseMvc(routes =>
	    {
			routes.MapRoute(
				name: "default",
				template: "{controller=Start}/{action=Index}/{id?}");

				// Setup additional routing for SPA
				routes.MapSpaFallbackRoute(
					name: "spa-fallback",
					defaults: new { controller = "Start", action = "Index" });
	    });
	}
    }
}
