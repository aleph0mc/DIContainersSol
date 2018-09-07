using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using ServiceLib;

namespace AutofacContainer
{
    public class InitComponents
    {
        public static void InitializeComponents()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<Client>();
            builder.RegisterInstance(new Service1()).As<IService1>();
            builder.RegisterInstance(new Service2()).As<IService2>().SingleInstance();

            var container = builder.Build();
            var client = container.Resolve<Client>();

            client.InitiateServiceMethods();
        }
    }
}
