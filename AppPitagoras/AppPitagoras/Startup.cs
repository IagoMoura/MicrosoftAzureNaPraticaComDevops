using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AppPitagoras.Startup))]
namespace AppPitagoras
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
