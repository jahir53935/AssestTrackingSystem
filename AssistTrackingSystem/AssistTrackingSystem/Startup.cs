using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AssistTrackingSystem.Startup))]
namespace AssistTrackingSystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
