using Abp.AspNetCore.SignalR;
using Abp.Dependency;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace TEST.DataServiceApplication
{
    [DependsOn(
    typeof(TESTCoreModule),
        typeof(AbpAspNetCoreSignalRModule))]
    public class TESTDataServiceApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(TESTDataServiceApplicationModule).GetAssembly());
        }

        public override void PostInitialize()
        {
            //var workManager = IocManager.Resolve<IApplicationService>();
            //workManager.Add(IocManager.Resolve<DataBuilder>());

            IocManager.Register<FilterBuilder>(DependencyLifeStyle.Transient);

        }

    }
}
