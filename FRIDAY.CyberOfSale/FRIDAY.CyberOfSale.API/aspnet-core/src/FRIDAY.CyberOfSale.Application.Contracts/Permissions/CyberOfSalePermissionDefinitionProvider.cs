using FRIDAY.CyberOfSale.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace FRIDAY.CyberOfSale.Permissions
{
    public class CyberOfSalePermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(CyberOfSalePermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(CyberOfSalePermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<CyberOfSaleResource>(name);
        }
    }
}
