using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EMA.Disaster.Recovery.Startup))]
namespace EMA.Disaster.Recovery
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
