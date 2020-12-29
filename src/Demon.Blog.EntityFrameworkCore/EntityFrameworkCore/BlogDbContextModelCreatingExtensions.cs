using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace Demon.Blog.EntityFrameworkCore
{
    public static class BlogDbContextModelCreatingExtensions
    {
        public static void ConfigureBlog(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(BlogConsts.DbTablePrefix + "YourEntities", BlogConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
        }
    }
}