using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SchoolProyecto2.Startup))]
namespace SchoolProyecto2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
