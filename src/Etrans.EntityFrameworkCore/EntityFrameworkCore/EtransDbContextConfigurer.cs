using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Etrans.EntityFrameworkCore
{
    public static class EtransDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<EtransDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<EtransDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
