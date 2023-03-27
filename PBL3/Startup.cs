using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PBL3.Startup))]
namespace PBL3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
