using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using TEST.Configuration;
using TEST.Web;

namespace TEST.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class TESTDbContextFactory : IDesignTimeDbContextFactory<TESTDbContext>
    {
        public TESTDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<TESTDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            TESTDbContextConfigurer.Configure(builder, configuration.GetConnectionString(TESTConsts.ConnectionStringName));

            return new TESTDbContext(builder.Options);
        }
    }
}
