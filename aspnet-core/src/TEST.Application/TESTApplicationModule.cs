using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using TEST.Authorization;

namespace TEST
{
    [DependsOn(
        typeof(TESTCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class TESTApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<TESTAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(TESTApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
