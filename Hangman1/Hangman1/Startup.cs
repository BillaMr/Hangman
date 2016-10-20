using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Hangman1.Startup))]
namespace Hangman1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
