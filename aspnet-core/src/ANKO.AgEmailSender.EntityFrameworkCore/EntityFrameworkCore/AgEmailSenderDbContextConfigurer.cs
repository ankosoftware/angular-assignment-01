using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace ANKO.AgEmailSender.EntityFrameworkCore
{
    public static class AgEmailSenderDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<AgEmailSenderDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<AgEmailSenderDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
