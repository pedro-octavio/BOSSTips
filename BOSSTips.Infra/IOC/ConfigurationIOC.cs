using Autofac;
using BOSSTips.Infra.Data.Interfaces;
using BOSSTips.Infra.Data.Repositories;

namespace BOSSTips.Infra.IOC
{
    public class ConfigurationIOC
    {
        public static void Load(ContainerBuilder containerBuilder)
        {
            containerBuilder.RegisterType<BossRepository>().As<IBossRepository>();
        }
    }
}
