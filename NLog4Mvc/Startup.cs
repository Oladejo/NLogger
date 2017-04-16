using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NLog4Mvc.Startup))]
namespace NLog4Mvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
