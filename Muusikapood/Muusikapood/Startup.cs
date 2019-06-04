using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Muusikapood.Startup))]
namespace Muusikapood
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
