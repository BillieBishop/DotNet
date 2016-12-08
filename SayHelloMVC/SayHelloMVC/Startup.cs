using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SayHelloMVC.Startup))]
namespace SayHelloMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
