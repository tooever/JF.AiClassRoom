using Abp.Application.Services;
using Abp.AspNetCore;
using Abp.AspNetCore.Configuration;
using Abp.Configuration.Startup;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.WebApi;
using JF.AiClassRoom.Configuration;
using JF.AiClassRoom.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.ApplicationParts;
using Microsoft.Extensions.Configuration;
using System.Reflection;

namespace JF.AiClassRoom.Web.Startup
{
    [DependsOn(
        typeof(AiClassRoomApplicationModule),
        typeof(AiClassRoomEntityFrameworkCoreModule),
        typeof(AbpAspNetCoreModule))]
    public class AiClassRoomWebModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public AiClassRoomWebModule(IHostingEnvironment env)
        {
            _appConfiguration = AppConfigurations.Get(env.ContentRootPath, env.EnvironmentName);
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(AiClassRoomConsts.ConnectionStringName);

            Configuration.Navigation.Providers.Add<AiClassRoomNavigationProvider>();

            Configuration.Modules.AbpAspNetCore()
                .CreateControllersForAppServices(
                    typeof(AiClassRoomApplicationModule).GetAssembly(),
                "bookservice");
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AiClassRoomWebModule).GetAssembly());
        }

        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(AiClassRoomWebModule).Assembly);
        }
    }
}