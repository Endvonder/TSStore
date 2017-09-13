using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TShirtStore.WebUI.Startup))]
namespace TShirtStore.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
