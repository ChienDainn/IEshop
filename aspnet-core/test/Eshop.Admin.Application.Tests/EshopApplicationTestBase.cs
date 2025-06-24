using Volo.Abp.Modularity;

namespace Eshop.Admin;

public abstract class EshopApplicationTestBase<TStartupModule> : EshopTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
