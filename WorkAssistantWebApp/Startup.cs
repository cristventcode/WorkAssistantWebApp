using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WorkAssistantWebApp.Startup))]
namespace WorkAssistantWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
