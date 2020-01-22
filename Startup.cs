using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Avery_MIS4200.Startup))]
namespace Avery_MIS4200
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
