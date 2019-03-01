using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MaAccount.Authorization;

namespace MaAccount
{
    [DependsOn(
        typeof(MaAccountCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class MaAccountApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<MaAccountAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(MaAccountApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
