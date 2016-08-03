using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebSGAACF.Startup))]
namespace WebSGAACF
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
