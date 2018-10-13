using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FWPaws6.Startup))]
namespace FWPaws6
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
