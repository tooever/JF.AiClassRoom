using JF.AiClassRoom.Configuration;
using JF.AiClassRoom.Web;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace JF.AiClassRoom.EntityFrameworkCore
{
    /* This class is needed to run EF Core PMC commands. Not used anywhere else */
    public class AiClassRoomDbContextFactory : IDesignTimeDbContextFactory<AiClassRoomDbContext>
    {
        public AiClassRoomDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<AiClassRoomDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            DbContextOptionsConfigurer.Configure(
                builder,
                configuration.GetConnectionString(AiClassRoomConsts.ConnectionStringName)
            );

            return new AiClassRoomDbContext(builder.Options);
        }
    }
}