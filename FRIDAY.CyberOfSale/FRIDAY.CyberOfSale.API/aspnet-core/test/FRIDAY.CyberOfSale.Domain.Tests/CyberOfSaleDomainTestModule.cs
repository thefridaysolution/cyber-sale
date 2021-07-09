using FRIDAY.CyberOfSale.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace FRIDAY.CyberOfSale
{
    [DependsOn(
        typeof(CyberOfSaleEntityFrameworkCoreTestModule)
        )]
    public class CyberOfSaleDomainTestModule : AbpModule
    {

    }
}