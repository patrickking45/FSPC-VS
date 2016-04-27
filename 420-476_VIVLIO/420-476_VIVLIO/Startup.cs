using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_420_476_VIVLIO.Startup))]
namespace _420_476_VIVLIO
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
