using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PusherChannels.Startup))]
namespace PusherChannels
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
