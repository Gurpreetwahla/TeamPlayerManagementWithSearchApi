using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TeamPlayerManagementWithSearchApi.Startup))]
namespace TeamPlayerManagementWithSearchApi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
