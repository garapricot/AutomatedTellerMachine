using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AutoMatedAutomatedTellerMachine.Startup))]
namespace AutoMatedAutomatedTellerMachine
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
