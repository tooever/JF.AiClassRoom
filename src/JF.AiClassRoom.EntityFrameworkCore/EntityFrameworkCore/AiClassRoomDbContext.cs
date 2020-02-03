using Abp.EntityFrameworkCore;
using JF.AiClassRoom.Books;
using Microsoft.EntityFrameworkCore;

namespace JF.AiClassRoom.EntityFrameworkCore
{
    public class AiClassRoomDbContext : AbpDbContext
    {
        //Add DbSet properties for your entities...
        public DbSet<Book> Book { get; set; }
        public AiClassRoomDbContext(DbContextOptions<AiClassRoomDbContext> options)
            : base(options)
        {

        }
    }
}
