using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IdentityTutorialNCapas.Startup))]
namespace IdentityTutorialNCapas
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
