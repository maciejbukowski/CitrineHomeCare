using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CitrineHomeHealth.Startup))]
namespace CitrineHomeHealth
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
