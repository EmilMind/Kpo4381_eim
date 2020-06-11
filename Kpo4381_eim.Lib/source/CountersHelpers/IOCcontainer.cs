using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.MicroKernel.Registration;
using Castle.Windsor;

namespace Kpo4381.eim.Lib
{
    public static class IOCcontainer
    {
        public static WindsorContainer container { get; private set; }

        static IOCcontainer()
        {
            switch (AppGlobalSettings.officePacksFactory)
            {
                case "splitFile":
                    container = new WindsorContainer();
                    container.Register(Component
                        .For<IOfficePacksListLoader>()
                        .ImplementedBy<OfficePacksListSplitFileLoader>()
                        .LifeStyle.Singleton
                        );
                    container.Register(Component
                        .For<IOfficePacksListSaver>()
                        .ImplementedBy<OfficePacksListSplitFileSaver>()
                        .LifeStyle.Singleton
                        );
                    break;
                case "test":
                    container = new WindsorContainer();
                    container.Register(Component
                        .For<IOfficePacksListLoader>()
                        .ImplementedBy<OfficePacksListTestLoader>()
                        .LifeStyle.Singleton
                        );
                    container.Register(Component
                        .For<IOfficePacksListSaver>()
                        .ImplementedBy<OfficePacksListTestSaver>()
                        .LifeStyle.Singleton
                        );
                    break;
                default:
                    container = new WindsorContainer();
                    container.Register(Component
                        .For<IOfficePacksListLoader>()
                        .ImplementedBy<OfficePacksListSplitFileLoader>()
                        .LifeStyle.Singleton
                        );
                    container.Register(Component
                        .For<IOfficePacksListSaver>()
                        .ImplementedBy<OfficePacksListSplitFileSaver>()
                        .LifeStyle.Singleton
                        );
                    break;
            }

        }
    }
}
