using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace FRIDAY.CyberOfSale.EntityFrameworkCore
{
    public static class CyberOfSaleDbContextModelCreatingExtensions
    {
        public static void ConfigureCyberOfSale(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(CyberOfSaleConsts.DbTablePrefix + "YourEntities", CyberOfSaleConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
        }
    }
}