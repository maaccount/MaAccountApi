using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace MaAccount.EntityFrameworkCore
{
    public static class MaAccountDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<MaAccountDbContext> builder, string connectionString)
        {
            builder.UseMySql(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<MaAccountDbContext> builder, DbConnection connection)
        {
            builder.UseMySql(connection);
        }
    }
}
