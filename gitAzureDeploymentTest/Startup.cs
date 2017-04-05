using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(gitAzureDeploymentTest.Startup))]
namespace gitAzureDeploymentTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
