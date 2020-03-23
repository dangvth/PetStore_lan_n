using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PetStoreWebClient.Startup))]
namespace PetStoreWebClient
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
