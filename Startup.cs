using Microsoft.Owin;
using Owin;
using Zgloszenie_WebApplication.ViewModel;

[assembly: OwinStartupAttribute(typeof(Zgloszenie_WebApplication.Startup))]
namespace Zgloszenie_WebApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
           CraeteRolesAndUsers.createRolesandUsers();
        }
    }

   

    }
