using System.Threading.Tasks;

namespace Demon.Blog.Data
{
    public interface IBlogDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
