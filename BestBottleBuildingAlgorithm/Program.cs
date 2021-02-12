using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestBottleBuildingAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BufferWidth = 1024;
            Console.BufferHeight = 1024;
            Console.ReadKey();
            Console.WriteLine(Person.DoWork(new IncrementalStrategy()));
            Console.WriteLine(Person.DoWork(new IncrementDynamicStrategy()));
            Console.ReadLine();
        }
    }    
}
