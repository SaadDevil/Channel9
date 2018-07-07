using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Channel9.Startup))]
namespace Channel9
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
