using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ClayShannon_SD1_Redo.Startup))]
namespace ClayShannon_SD1_Redo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
