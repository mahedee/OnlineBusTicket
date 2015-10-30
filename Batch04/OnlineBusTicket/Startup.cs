using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OnlineBusTicket.Startup))]
namespace OnlineBusTicket
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
