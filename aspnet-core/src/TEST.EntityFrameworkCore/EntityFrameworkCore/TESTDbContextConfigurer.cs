using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace TEST.EntityFrameworkCore
{
    public static class TESTDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<TESTDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<TESTDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
