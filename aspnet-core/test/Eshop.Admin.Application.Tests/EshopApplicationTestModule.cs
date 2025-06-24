using Volo.Abp.Modularity;

namespace Eshop.Admin;

[DependsOn(
    typeof(EshopAdminApplicationModule),
    typeof(EshopDomainTestModule)
)]
public class EshopApplicationTestModule : AbpModule
{

}
