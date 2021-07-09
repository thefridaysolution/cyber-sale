using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace FRIDAY.CyberOfSale
{
    [Dependency(ReplaceServices = true)]
    public class CyberOfSaleBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "CyberOfSale";
    }
}
