using Microsoft.Owin;
using Owin;
using Chatter;

[assembly: OwinStartupAttribute(typeof(Chatter.Startup))]
namespace Chatter
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);

            app.MapSignalR();
        }
    }
}
