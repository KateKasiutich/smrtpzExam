using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ExamApp.Startup))]
namespace ExamApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
