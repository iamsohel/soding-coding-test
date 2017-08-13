using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SodingCodingTest.Startup))]
namespace SodingCodingTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
