using System;
using System.Collections.Generic;
using System.Text;
using Eshop.Localization;
using Volo.Abp.Application.Services;

namespace Eshop;

/* Inherit your application services from this class.
 */
public abstract class EshopAdminAppService : ApplicationService
{
    protected EshopAdminAppService()
    {
        LocalizationResource = typeof(EshopResource);
    }
}
