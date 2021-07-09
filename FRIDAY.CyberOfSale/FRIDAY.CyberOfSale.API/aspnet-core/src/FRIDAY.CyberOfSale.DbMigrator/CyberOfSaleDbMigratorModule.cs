using FRIDAY.CyberOfSale.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace FRIDAY.CyberOfSale.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(CyberOfSaleEntityFrameworkCoreDbMigrationsModule),
        typeof(CyberOfSaleApplicationContractsModule)
        )]
    public class CyberOfSaleDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
