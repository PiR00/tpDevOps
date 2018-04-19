using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(tpDevOps.Startup))]
namespace tpDevOps
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
