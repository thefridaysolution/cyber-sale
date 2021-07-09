using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace FRIDAY.CyberOfSale.Data
{
    /* This is used if database provider does't define
     * ICyberOfSaleDbSchemaMigrator implementation.
     */
    public class NullCyberOfSaleDbSchemaMigrator : ICyberOfSaleDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}