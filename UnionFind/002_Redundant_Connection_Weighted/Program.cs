using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Redundant_Connection_Weighted
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * For the same above problem, we are going to give one more improvement.
             * When we want to group two element (A, B),
             * we will get roots of these elements (r1, r2)
             * We will check, which group have more capacity, we will add the small group to the other group.
             * So that the execution will be faster.
             */
            var sln = new Solution();
            var edges = new int[3][]
            {
                    new int[]{1,2},
                    new int[]{1,3},
                    new int[]{2,3}
            };
            var ans = sln.FindRedundantConnection(edges);
            foreach (var item in ans)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine();
        }
        public class Solution
        {
            public int[] FindRedundantConnection(int[][] edges)
            {
                var uf = new UnionFind();
                for (int i = 0; i < edges.Length; i++)
                {
                    if (!uf.Union(edges[i][0], edges[i][1]))
                    {
                        return edges[i];
                    }
                }

                return new int[0];
            }
        }
    }
}
