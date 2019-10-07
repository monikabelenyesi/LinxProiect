using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LinxSolutionProiect2.Startup))]
namespace LinxSolutionProiect2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
