using Abp.AutoMapper;
using Abp.FluentValidation;
using Abp.FluentValidation.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using FluentValidation;
using JF.AiClassRoom.Dtos.Books;
using JF.AiClassRoom.Validation;

namespace JF.AiClassRoom
{
    [DependsOn(
        typeof(AiClassRoomCoreModule), 
        typeof(AbpAutoMapperModule),
        typeof(AbpFluentValidationModule))]
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