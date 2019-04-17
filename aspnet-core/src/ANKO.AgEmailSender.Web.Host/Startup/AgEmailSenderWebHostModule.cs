using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ANKO.AgEmailSender.Configuration;

namespace ANKO.AgEmailSender.Web.Host.Startup
{
    [DependsOn(
       typeof(AgEmailSenderWebCoreModule))]
    public class AgEmailSenderWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public AgEmailSenderWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AgEmailSenderWebHostModule).GetAssembly());
        }
    }
}
