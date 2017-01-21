using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Shipping1.Startup))]
namespace Shipping1
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
