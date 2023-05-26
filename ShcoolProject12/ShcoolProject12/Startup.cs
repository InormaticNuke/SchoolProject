using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ShcoolProject12.Startup))]
namespace ShcoolProject12
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
