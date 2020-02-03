using Abp.Modules;
using Abp.Reflection.Extensions;
using JF.AiClassRoom.Localization;

namespace JF.AiClassRoom
{
    public class AiClassRoomCoreModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Auditing.IsEnabledForAnonymousUsers = true;

            AiClassRoomLocalizationConfigurer.Configure(Configuration.Localization);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AiClassRoomCoreModule).GetAssembly());
        }
    }
}