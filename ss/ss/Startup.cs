using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ss.Startup))]
namespace ss
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
