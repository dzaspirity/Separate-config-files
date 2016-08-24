using System;
using System.Configuration;
using System.Net.Mime;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using LibSettings = ClassLibrarySample.Properties.Settings;
using WebSettings = WebApplicationSample.Properties.Settings;


[assembly: OwinStartup(typeof(WebApplicationSample.Startup))]

namespace WebApplicationSample
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.Run(Process);
        }

        private async Task Process(IOwinContext context)
        {
            await context.Response.WriteAsync(ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString + Environment.NewLine);
            await context.Response.WriteAsync($"LibS1: {LibSettings.Default.LibS1}{Environment.NewLine}");
            await context.Response.WriteAsync($"WebS1: {WebSettings.Default.WebS1}{Environment.NewLine}");
            context.Response.ContentType = MediaTypeNames.Text.Plain;
        }
    }
}
