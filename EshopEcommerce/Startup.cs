using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EshopEcommerce.Startup))]
namespace EshopEcommerce
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
