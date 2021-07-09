using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace FRIDAY.CyberOfSale.EntityFrameworkCore
{
    [DependsOn(
        typeof(CyberOfSaleEntityFrameworkCoreModule)
        )]
    public class CyberOfSaleEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<CyberOfSaleMigrationsDbContext>();
        }
    }
}
