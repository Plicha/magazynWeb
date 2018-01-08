using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(magazynWeb.Startup))]
namespace magazynWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
