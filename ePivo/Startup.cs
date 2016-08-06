using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ePivo.Startup))]
namespace ePivo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
