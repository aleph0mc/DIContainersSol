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
            CastleWindsorContainer.InitComponents.InitializeComponents();

            AutofacContainer.InitComponents.InitializeComponents();

            StructureMapContainer.InitComponents.InitializeComponents();
        }
    }
}
