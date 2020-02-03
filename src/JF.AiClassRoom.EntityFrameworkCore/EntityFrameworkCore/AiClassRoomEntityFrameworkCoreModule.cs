using Abp.Dapper;
using Abp.EntityFrameworkCore;
using Abp.Modules;
using Abp.Reflection.Extensions;
using DapperExtensions.Sql;
using System.Collections.Generic;
using System.Reflection;

namespace JF.AiClassRoom.EntityFrameworkCore
{
    [DependsOn(
        typeof(AiClassRoomCoreModule), 
        typeof(AbpEntityFrameworkCoreModule),
        typeof(AbpDapperModule))]
    public class AiClassRoomEntityFrameworkCoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AiClassRoomEntityFrameworkCoreModule).GetAssembly());
            DapperExtensions.DapperExtensions.SetMappingAssemblies(new List<Assembly> { typeof(AiClassRoomEntityFrameworkCoreModule).GetAssembly() });
            DapperExtensions.DapperExtensions.SqlDialect = new MySqlDialect();
        }
    }
}