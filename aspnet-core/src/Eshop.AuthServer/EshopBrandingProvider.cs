using Microsoft.Extensions.Localization;
using Eshop.Localization;
using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Eshop;

[Dependency(ReplaceServices = true)]
public class EshopBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<EshopResource> _localizer;

    public EshopBrandingProvider(IStringLocalizer<EshopResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
