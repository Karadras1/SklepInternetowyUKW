using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(SklepUKW.StartupOwin))]

namespace SklepUKW
{
    public partial class StartupOwin
    {
        public void Configuration(IAppBuilder app)
        {
            //AuthStartup.ConfigureAuth(app);
        }
    }
}
