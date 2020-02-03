using System;
using System.Threading.Tasks;
using Abp.TestBase;
using JF.AiClassRoom.EntityFrameworkCore;
using JF.AiClassRoom.Tests.TestDatas;

namespace JF.AiClassRoom.Tests
{
    public class AiClassRoomTestBase : AbpIntegratedTestBase<AiClassRoomTestModule>
    {
        public AiClassRoomTestBase()
        {
            UsingDbContext(context => new TestDataBuilder(context).Build());
        }

        protected virtual void UsingDbContext(Action<AiClassRoomDbContext> action)
        {
            using (var context = LocalIocManager.Resolve<AiClassRoomDbContext>())
            {
                action(context);
                context.SaveChanges();
            }
        }

        protected virtual T UsingDbContext<T>(Func<AiClassRoomDbContext, T> func)
        {
            T result;

            using (var context = LocalIocManager.Resolve<AiClassRoomDbContext>())
            {
                result = func(context);
                context.SaveChanges();
            }

            return result;
        }

        protected virtual async Task UsingDbContextAsync(Func<AiClassRoomDbContext, Task> action)
        {
            using (var context = LocalIocManager.Resolve<AiClassRoomDbContext>())
            {
                await action(context);
                await context.SaveChangesAsync(true);
            }
        }

        protected virtual async Task<T> UsingDbContextAsync<T>(Func<AiClassRoomDbContext, Task<T>> func)
        {
            T result;

            using (var context = LocalIocManager.Resolve<AiClassRoomDbContext>())
            {
                result = await func(context);
                context.SaveChanges();
            }

            return result;
        }
    }
}
