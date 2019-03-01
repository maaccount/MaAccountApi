using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MaAccount.Configuration;

namespace MaAccount.Web.Host.Startup
{
    [DependsOn(
       typeof(MaAccountWebCoreModule))]
    public class MaAccountWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public MaAccountWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MaAccountWebHostModule).GetAssembly());
        }
    }
}
