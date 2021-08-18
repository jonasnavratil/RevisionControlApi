using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using RevisionControl.EntityFrameworkCore;
using RevisionControl.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace RevisionControl.Web.Tests
{
    [DependsOn(
        typeof(RevisionControlWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class RevisionControlWebTestModule : AbpModule
    {
        public RevisionControlWebTestModule(RevisionControlEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(RevisionControlWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(RevisionControlWebMvcModule).Assembly);
        }
    }
}