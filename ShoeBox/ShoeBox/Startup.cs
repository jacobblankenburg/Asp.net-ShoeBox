using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ShoeBox.Startup))]
namespace ShoeBox
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
