using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace RevisionControl.EntityFrameworkCore
{
    public static class RevisionControlDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<RevisionControlDbContext> builder, string connectionString)
        {
            builder.UseNpgsql(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<RevisionControlDbContext> builder, DbConnection connection)
        {
            builder.UseNpgsql(connection);
        }
    }
}
