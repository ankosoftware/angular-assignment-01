using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ANKO.AgEmailSender.Authorization;

namespace ANKO.AgEmailSender
{
    [DependsOn(
        typeof(AgEmailSenderCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class AgEmailSenderApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<AgEmailSenderAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(AgEmailSenderApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
