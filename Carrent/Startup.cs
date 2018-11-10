using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Carrent.Startup))]
namespace Carrent
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
