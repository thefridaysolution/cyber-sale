using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using FRIDAY.CyberOfSale.Data;
using Volo.Abp.DependencyInjection;

namespace FRIDAY.CyberOfSale.EntityFrameworkCore
{
    public class EntityFrameworkCoreCyberOfSaleDbSchemaMigrator
        : ICyberOfSaleDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreCyberOfSaleDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the CyberOfSaleMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<CyberOfSaleMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}