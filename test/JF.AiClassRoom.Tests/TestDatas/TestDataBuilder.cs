using JF.AiClassRoom.EntityFrameworkCore;

namespace JF.AiClassRoom.Tests.TestDatas
{
    public class TestDataBuilder
    {
        private readonly AiClassRoomDbContext _context;

        public TestDataBuilder(AiClassRoomDbContext context)
        {
            _context = context;
        }

        public void Build()
        {
            //create test data here...
        }
    }
}