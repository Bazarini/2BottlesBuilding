using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestBottleBuildingAlgorithm
{
    public static class Person
    {
        
        public static int DoWork(ThrowStrategy strategy)
        {
            
            List<List<ThrowsResult>> throwsResultsTable = new List<List<ThrowsResult>>();
            for (int breakFloor = 1; breakFloor <= 100; breakFloor++)
            {

                List<ThrowsResult> floorResults = strategy.UseStrategy(breakFloor);
                throwsResultsTable.Add(floorResults);
            }
            throwsResultsTable = throwsResultsTable.Transpose();
            IEnumerable<int> minResults = throwsResultsTable.Select(s =>  s.Max(m => m.Throws) );
            //for (int j = 0; j < minResults.Count(); j++)
            //{
            //    for (int i = 0; i <= 100; i++)
            //    {
            //        if (i <= minResults.ElementAt(j))
            //        {
            //            if (strategy is IncrementalStrategy)
            //            {
            //                Console.BackgroundColor = ConsoleColor.White;
            //                Console.ForegroundColor = ConsoleColor.Black;
            //            }
            //            else
            //            {
            //                Console.BackgroundColor = ConsoleColor.Blue;
            //                Console.ForegroundColor = ConsoleColor.Black;
            //            }
            //        }
            //        else
            //        {
            //            continue;
            //        }
            //        Console.Write(i.ToString("00"));
            //        Console.BackgroundColor = ConsoleColor.Black;
            //        Console.ForegroundColor = ConsoleColor.White;
            //        Console.SetCursorPosition(Console.CursorLeft - 2, Console.CursorTop + 1);
            //    }
            //    Console.SetCursorPosition((j+1) * 4, 0);
            //}
            //Console.SetCursorPosition(0,0);
            Console.Write($"{strategy.GetType().Name}: ");
            return minResults.Min();
            
        }
    }
}
