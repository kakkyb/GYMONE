using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SysbyteTest.Startup))]
namespace SysbyteTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
