using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Orca_Zwei_The_Reckoning_Redux.Startup))]
namespace Orca_Zwei_The_Reckoning_Redux
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
