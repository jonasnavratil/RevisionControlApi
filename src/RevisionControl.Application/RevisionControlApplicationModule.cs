using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using RevisionControl.Authorization;
using WkHtmlToPdfDotNet;
using WkHtmlToPdfDotNet.Contracts;

namespace RevisionControl
{
    [DependsOn(
        typeof(RevisionControlCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class RevisionControlApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<RevisionControlAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(RevisionControlApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
