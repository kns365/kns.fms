using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using kns.fms.EntityFrameworkCore;
using kns.fms.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace kns.fms.Web.Tests
{
    [DependsOn(
        typeof(fmsWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class fmsWebTestModule : AbpModule
    {
        public fmsWebTestModule(fmsEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(fmsWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(fmsWebMvcModule).Assembly);
        }
    }
}