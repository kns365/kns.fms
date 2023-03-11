using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace kns.fms.EntityFrameworkCore
{
    public static class fmsDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<fmsDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<fmsDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
