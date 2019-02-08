using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(atmproject.Startup))]
namespace atmproject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
