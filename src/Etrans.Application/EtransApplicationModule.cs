using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Etrans.Authorization;

namespace Etrans
{
    [DependsOn(
        typeof(EtransCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class EtransApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<EtransAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(EtransApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(cfg =>
            {
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg.AddProfiles(thisAssembly);
            });
        }
    }
}
