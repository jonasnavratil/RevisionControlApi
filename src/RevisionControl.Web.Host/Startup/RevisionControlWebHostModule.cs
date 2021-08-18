using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using RevisionControl.Configuration;

namespace RevisionControl.Web.Host.Startup
{
    [DependsOn(
       typeof(RevisionControlWebCoreModule))]
    public class RevisionControlWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public RevisionControlWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(RevisionControlWebHostModule).GetAssembly());
        }
    }
}
