using System.Threading.Tasks;

namespace FRIDAY.CyberOfSale.Data
{
    public interface ICyberOfSaleDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
