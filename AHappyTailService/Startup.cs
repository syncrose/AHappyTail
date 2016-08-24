using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(AHappyTailService.Startup))]

namespace AHappyTailService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}