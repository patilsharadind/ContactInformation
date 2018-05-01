using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ContactInformation.Web.Startup))]
namespace ContactInformation.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
          //  ConfigureAuth(app);
        }
    }
}
