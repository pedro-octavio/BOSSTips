using Autofac;

namespace BOSSTips.Infra.IOC
{
    public class ModuleIOC : Module
    {
        protected override void Load(ContainerBuilder containerBuilder) => ConfigurationIOC.Load(containerBuilder);
    }
}
