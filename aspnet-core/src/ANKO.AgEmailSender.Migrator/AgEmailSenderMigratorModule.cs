using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ANKO.AgEmailSender.Configuration;
using ANKO.AgEmailSender.EntityFrameworkCore;
using ANKO.AgEmailSender.Migrator.DependencyInjection;

namespace ANKO.AgEmailSender.Migrator
{
    [DependsOn(typeof(AgEmailSenderEntityFrameworkModule))]
    public class AgEmailSenderMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public AgEmailSenderMigratorModule(AgEmailSenderEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(AgEmailSenderMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                AgEmailSenderConsts.ConnectionStringName
            );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(
                typeof(IEventBus), 
                () => IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                )
            );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AgEmailSenderMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
