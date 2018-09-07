using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StructureMap;
using ServiceLib;

namespace StructureMapContainer
{
    public class InitComponents
    {
        public static void InitializeComponents()
        {
            var container = new StructureMap.Container(x =>
            {
                x.For<IService1>().Use<Service1>().Transient();
                x.For<IService2>().Use<Service2>().Singleton();
                x.For<Client>().Use<Client>();
            });

            var client = container.GetInstance<Client>();

            client.InitiateServiceMethods();

            container.Release(client);
        }
    }
}
