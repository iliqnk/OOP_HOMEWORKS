using System;
using System.Collections.Generic;

namespace _03.PCCatalog
{
    class PCCatalog
    {
        static void Main()
        {
            List<Component> components = new List<Component>();
            components.Add(new Component("CPU", 120));
            components.Add(new Component("GPU", 390.39M));
            components.Add(new Component("Motherboard", 163.24M));

            Computer pc = new Computer("Dell", components);
            //Console.WriteLine(pc);
            //Console.WriteLine();

            pc.AddComponent(new Component("RAM", 98.63M, "8GB"));
            //Console.WriteLine(pc);

            List<Computer> pcCatalog = new List<Computer>();
            
            List<Component> expensiveComp = new List<Component>();
            expensiveComp.Add(new Component("CPU", 956.32M));
            expensiveComp.Add(new Component("GPU", 1322.26M));
            expensiveComp.Add(new Component("RAM", 156.21M, "16GB"));

            pcCatalog.Add(new Computer("GamerPC", expensiveComp));
            pcCatalog.Add(pc);
            pcCatalog.Sort();
            foreach (var computer in pcCatalog)
            {
                Console.WriteLine(computer);
            }
        }
    }
}
