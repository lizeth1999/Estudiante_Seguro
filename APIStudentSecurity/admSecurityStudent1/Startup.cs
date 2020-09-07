using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(admSecurityStudent1.Startup))]
namespace admSecurityStudent1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
