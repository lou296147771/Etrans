using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Etrans.Configuration;
using Etrans.Web;

namespace Etrans.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class EtransDbContextFactory : IDesignTimeDbContextFactory<EtransDbContext>
    {
        public EtransDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<EtransDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            EtransDbContextConfigurer.Configure(builder, configuration.GetConnectionString(EtransConsts.ConnectionStringName));

            return new EtransDbContext(builder.Options);
        }
    }
}
