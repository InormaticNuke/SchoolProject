using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SchoolProject10.Startup))]
namespace SchoolProject10
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
