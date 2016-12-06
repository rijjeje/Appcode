using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(cheftestapp.Startup))]
namespace cheftestapp
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
