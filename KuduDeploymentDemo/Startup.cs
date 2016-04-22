using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KuduDeploymentDemo.Startup))]
namespace KuduDeploymentDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
