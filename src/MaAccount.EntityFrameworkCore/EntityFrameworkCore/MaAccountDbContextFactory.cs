using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using MaAccount.Configuration;
using MaAccount.Web;

namespace MaAccount.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class MaAccountDbContextFactory : IDesignTimeDbContextFactory<MaAccountDbContext>
    {
        public MaAccountDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<MaAccountDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            MaAccountDbContextConfigurer.Configure(builder, configuration.GetConnectionString(MaAccountConsts.ConnectionStringName));

            return new MaAccountDbContext(builder.Options);
        }
    }
}
