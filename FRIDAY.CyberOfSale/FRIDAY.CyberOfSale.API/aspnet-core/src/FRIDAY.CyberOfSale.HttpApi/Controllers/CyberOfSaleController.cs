using FRIDAY.CyberOfSale.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace FRIDAY.CyberOfSale.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class CyberOfSaleController : AbpController
    {
        protected CyberOfSaleController()
        {
            LocalizationResource = typeof(CyberOfSaleResource);
        }
    }
}