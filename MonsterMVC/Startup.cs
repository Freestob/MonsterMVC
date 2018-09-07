using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MonsterMVC.Startup))]
namespace MonsterMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
