using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mvc20.Startup))]
namespace mvc20
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
