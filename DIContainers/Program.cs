using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIContainers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Using Castle Windsor DI...");
            CastleWindsorContainer.InitComponents.InitializeComponents();

            Console.WriteLine("Using Autofac DI...");
            AutofacContainer.InitComponents.InitializeComponents();

            Console.WriteLine("Using StructureMap DI...");
            StructureMapContainer.InitComponents.InitializeComponents();

            Console.WriteLine("Using Microsoft DI...");
            MsDI_Container.InitComponents.InitializeComponents();
        }
    }
}
