using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using RevisionControl.Configuration;
using RevisionControl.Web;

namespace RevisionControl.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class RevisionControlDbContextFactory : IDesignTimeDbContextFactory<RevisionControlDbContext>
    {
        public RevisionControlDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<RevisionControlDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            RevisionControlDbContextConfigurer.Configure(builder, configuration.GetConnectionString(RevisionControlConsts.ConnectionStringName));

            return new RevisionControlDbContext(builder.Options);
        }
    }
}
