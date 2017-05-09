using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Garden.Web.Startup))]
namespace Garden.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
