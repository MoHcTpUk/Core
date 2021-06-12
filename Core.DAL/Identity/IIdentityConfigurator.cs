using Microsoft.Extensions.DependencyInjection;

namespace Core.DAL.Identity
{
    public interface IIdentityConfigurator
    {
        public void ConfigureIdentity(IServiceCollection serviceCollection);
    }
}
