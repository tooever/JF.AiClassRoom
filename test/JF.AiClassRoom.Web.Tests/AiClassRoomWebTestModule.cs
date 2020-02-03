using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using JF.AiClassRoom.Web.Startup;
namespace JF.AiClassRoom.Web.Tests
{
    [DependsOn(
        typeof(AiClassRoomWebModule),
        typeof(AbpAspNetCoreTestBaseModule)
        )]
    public class AiClassRoomWebTestModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AiClassRoomWebTestModule).GetAssembly());
        }
    }
}