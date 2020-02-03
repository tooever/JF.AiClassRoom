using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using JF.AiClassRoom.Books.Dtos;

namespace JF.AiClassRoom
{
    [DependsOn(
        typeof(AiClassRoomCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class AiClassRoomApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AiClassRoomApplicationModule).GetAssembly());
        }

        public override void PreInitialize()
        {
            Configuration.Modules.AbpAutoMapper().Configurators.Add(config =>
            {
                config.AddMaps(typeof(BookMapperProfile));
            });
        }
    }
}