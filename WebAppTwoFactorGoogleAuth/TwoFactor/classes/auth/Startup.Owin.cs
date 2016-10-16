using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAppTwoFactorGoogleAuth.Startup))]
namespace WebAppTwoFactorGoogleAuth
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
