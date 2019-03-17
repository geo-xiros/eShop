using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyEshopDemo.Startup))]
namespace MyEshopDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
