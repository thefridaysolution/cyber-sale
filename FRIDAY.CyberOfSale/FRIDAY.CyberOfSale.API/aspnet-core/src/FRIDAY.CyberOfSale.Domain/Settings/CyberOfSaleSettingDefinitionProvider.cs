using Volo.Abp.Settings;

namespace FRIDAY.CyberOfSale.Settings
{
    public class CyberOfSaleSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(CyberOfSaleSettings.MySetting1));
        }
    }
}
