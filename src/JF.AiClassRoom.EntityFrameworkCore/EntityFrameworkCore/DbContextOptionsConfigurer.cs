using Microsoft.EntityFrameworkCore;

namespace JF.AiClassRoom.EntityFrameworkCore
{
    public static class DbContextOptionsConfigurer
    {
        public static void Configure(
            DbContextOptionsBuilder<AiClassRoomDbContext> dbContextOptions, 
            string connectionString
            )
        {
            /* This is the single point to configure DbContextOptions for AiClassRoomDbContext */
            //dbContextOptions.UseSqlServer(connectionString);
            dbContextOptions.UseMySql(connectionString);
        }
    }
}
