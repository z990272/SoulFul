using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Soulful.Startup))]
namespace Soulful
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
