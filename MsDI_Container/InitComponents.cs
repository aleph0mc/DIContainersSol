using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using ServiceLib;

namespace MsDI_Container
{
    public class InitComponents
    {
        public static void InitializeComponents()
        {
            var serviceProvider = new ServiceCollection()
                .AddTransient<IClient, Client>()
                .AddTransient<IService1, Service1>()
                .AddSingleton<IService2, Service2>()
                .BuildServiceProvider();

            var client = serviceProvider.GetService<IClient>();

            client.InitiateServiceMethods();

        }
    }
}
