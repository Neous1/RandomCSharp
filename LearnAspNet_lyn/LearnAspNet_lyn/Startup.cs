using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LearnAspNet_lyn.Startup))]
namespace LearnAspNet_lyn
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
