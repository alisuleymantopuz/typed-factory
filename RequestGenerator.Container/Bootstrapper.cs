using Castle.Facilities.TypedFactory;
using Castle.Windsor;
using RequestGenerator.Container.Installers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestGenerator.Container
{
    public class Bootstrapper
    {
        public static IWindsorContainer Container { get; set; }

        public static void Initialize()
        {
            Container = new WindsorContainer();

            Container.AddFacility<TypedFactoryFacility>();

            Container.Install(new RequestGeneratorInstaller()); 
        }
    }
}



