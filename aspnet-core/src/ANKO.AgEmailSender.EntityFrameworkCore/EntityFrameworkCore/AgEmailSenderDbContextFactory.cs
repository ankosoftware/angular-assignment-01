using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using ANKO.AgEmailSender.Configuration;
using ANKO.AgEmailSender.Web;

namespace ANKO.AgEmailSender.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class AgEmailSenderDbContextFactory : IDesignTimeDbContextFactory<AgEmailSenderDbContext>
    {
        public AgEmailSenderDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<AgEmailSenderDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            AgEmailSenderDbContextConfigurer.Configure(builder, configuration.GetConnectionString(AgEmailSenderConsts.ConnectionStringName));

            return new AgEmailSenderDbContext(builder.Options);
        }
    }
}
