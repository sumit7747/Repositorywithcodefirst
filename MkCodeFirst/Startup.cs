using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MkCodeFirst.Startup))]
namespace MkCodeFirst
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
