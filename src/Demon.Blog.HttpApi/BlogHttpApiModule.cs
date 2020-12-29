using Volo.Abp.Identity;
using Volo.Abp.Modularity;

namespace Demon.Blog
{
    [DependsOn(
        typeof(AbpIdentityHttpApiModule),
        typeof(BlogApplicationModule)
        )]
    public class BlogHttpApiModule : AbpModule
    {
       
    }
}
