using System.Collections.Generic;

namespace BestBottleBuildingAlgorithm
{
    public static class Extensions
    {
        public static List<List<T>> Transpose<T>(this List<List<T>> table)
        {
            List<List<T>> output = new List<List<T>>();
            for (int i = 0; i < table.Count; i++)
            {
                for (int j = 0; j < table[i].Count; j++)
                {
                    if (i == 0)
                        output.Add(new List<T>());
                    output[j].Add(table[i][j]);
                }
            }

            table = null;
            return output;
        }
    }
}
