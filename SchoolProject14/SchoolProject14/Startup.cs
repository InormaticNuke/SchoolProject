using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SchoolProject14.Startup))]
namespace SchoolProject14
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
