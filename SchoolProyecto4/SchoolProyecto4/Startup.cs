using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SchoolProyecto4.Startup))]
namespace SchoolProyecto4
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
