using System;
using System.Collections.Generic;
using System.Text;
using FRIDAY.CyberOfSale.Localization;
using Volo.Abp.Application.Services;

namespace FRIDAY.CyberOfSale
{
    /* Inherit your application services from this class.
     */
    public abstract class CyberOfSaleAppService : ApplicationService
    {
        protected CyberOfSaleAppService()
        {
            LocalizationResource = typeof(CyberOfSaleResource);
        }
    }
}
