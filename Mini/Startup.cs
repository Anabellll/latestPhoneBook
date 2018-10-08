using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Mini.Startup))]
namespace Mini
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
