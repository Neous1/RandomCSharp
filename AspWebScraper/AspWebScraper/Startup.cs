using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AspWebScraper.Startup))]
namespace AspWebScraper
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
