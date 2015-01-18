using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DevSuperTest.Startup))]
namespace DevSuperTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
