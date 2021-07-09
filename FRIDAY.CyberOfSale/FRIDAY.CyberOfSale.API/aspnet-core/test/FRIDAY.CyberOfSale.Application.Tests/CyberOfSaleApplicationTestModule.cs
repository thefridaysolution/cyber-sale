using Volo.Abp.Modularity;

namespace FRIDAY.CyberOfSale
{
    [DependsOn(
        typeof(CyberOfSaleApplicationModule),
        typeof(CyberOfSaleDomainTestModule)
        )]
    public class CyberOfSaleApplicationTestModule : AbpModule
    {

    }
}