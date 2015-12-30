using Castle.Facilities.TypedFactory;
using Castle.MicroKernel.Registration;
using RequestGenerator.Container.TypedFactorySelectors;
using RequestGenerator.Domain.AlternatifBank;
using RequestGenerator.Domain.DefaultBank;
using RequestGenerator.Domain.LightBank;
using RequestGenerator.Domain.SoftBank;
using RequestGenerator.Domain.TransactionAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestGenerator.Container.Installers
{
    public class RequestGeneratorInstaller : IWindsorInstaller
    {
        public void Install(Castle.Windsor.IWindsorContainer container, Castle.MicroKernel.SubSystems.Configuration.IConfigurationStore store)
        {
            container.Register(Component.For<IRequestGeneratorManager>()
                .ImplementedBy<AlternatifBankRequestGeneratorManager>()
                .Named("AlternatifBankRequestGeneratorManager"));

            container.Register(Component.For<IRequestGeneratorManager>()
                .ImplementedBy<LigthBankRequestGeneratorManager>()
                .Named("LigthBankRequestGeneratorManager"));

            container.Register(Component.For<IRequestGeneratorManager>()
                .ImplementedBy<SoftBankRequestGeneratorManager>()
                .Named("SoftBankRequestGeneratorManager"));

            container.Register(Component.For<IRequestGeneratorManager>()
                .ImplementedBy<DefaultBankRequestGeneratorManager>()
                .Named("DefaultBankRequestGeneratorManager"));

            container.Register(Component.For<IRequestGeneratorFactory>()
                .AsFactory(c => c.SelectedWith(new RequestGeneratorTypedFactorySelector())));

            container.Register(Component.For<ITypedFactoryComponentSelector>()
                .ImplementedBy<RequestGeneratorTypedFactorySelector>());

        }
    }
}
