using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using kns.fms.Authorization;

namespace kns.fms
{
    [DependsOn(
        typeof(fmsCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class fmsApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<fmsAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(fmsApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
