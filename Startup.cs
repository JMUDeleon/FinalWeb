using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SocioRegistro.Startup))]
namespace SocioRegistro
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
