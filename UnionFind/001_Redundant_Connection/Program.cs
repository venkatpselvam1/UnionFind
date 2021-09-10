using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_Redundant_Connection
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * https://leetcode.com/problems/redundant-connection/
             * In this problem, a tree is an undirected graph that is connected and has no cycles.

             *You are given a graph that started as a tree with n nodes labeled from 1 to n, with one additional edge added.
             *The added edge has two different vertices chosen from 1 to n, and was not an edge that already existed.
             *The graph is represented as an array edges of length n where edges[i] = [ai, bi] indicates that there is an edge between nodes ai and bi in the graph.

             * Return an edge that can be removed so that the resulting graph is a tree of n nodes.
             * If there are multiple answers, return the answer that occurs last in the input.
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
                Console.Write(item+", ");
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
