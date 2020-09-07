using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(admStudent_Security.Startup))]
namespace admStudent_Security
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
