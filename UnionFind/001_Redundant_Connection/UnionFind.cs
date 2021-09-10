using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_Redundant_Connection
{
    public class UnionFind
    {
        // for the node i, the parent node is dict[i]
        // if a node don't present in the dict => it indicates it is root node.
        // initiall dict don't have any entry. So  all the nodes are root node.
        Dictionary<int, int> dict = new Dictionary<int, int>();
        public int GetRoot(int a)
        {
            // get root node, root node is something which is not in the dictionary
            while (dict.ContainsKey(a))
            {
                a = dict[a];
            }

            return a;
        }
        // The bool indicates if the children are already part of same group.
        // Adding them again, will create circular dependency.
        public bool Union(int a, int b)
        {
            var r1 = GetRoot(a);
            var r2 = GetRoot(b);
            if (r1 == r2)
            {
                return false;
            }
            // we are making r1's parent as r2
            dict.Add(r1, r2);
            return true;
        }
    }
}
