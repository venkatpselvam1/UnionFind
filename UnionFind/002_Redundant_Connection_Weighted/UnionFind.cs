using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Redundant_Connection_Weighted
{
    public class UnionFind
    {
        // for the any element i, dict[i] indicates the parent.
        // The parent of two property, one is index(next parent) and another is the group capacity.
        Dictionary<int, WeightedNode> dict = new Dictionary<int, WeightedNode>();

        private WeightedNode GetRoot(int a)
        {
            // if the given element is not part of the node, then it root node.
            // Add it to dict.
            if (!dict.ContainsKey(a))
            {
                dict.Add(a, new WeightedNode(a));
            }
            while (dict[a].I != a)
            {
                a = dict[a].I;
            }

            return dict[a];
        }

        public bool Union(int a, int b)
        {
            var r1 = GetRoot(a);
            var r2 = GetRoot(b);
            if (r1.I == r2.I)
            {
                return false;
            }

            if (r1.C > r2.C)
            {
                r2.I = r1.I;
                r1.C += r2.C;
            }
            else
            {
                r1.I = r2.I;
                r2.C += r1.C;
            }

            return true;
        }

        private class WeightedNode
        {
            public WeightedNode(int i)
            {
                this.I = i;
                this.C = 1;
            }
            // index of the parent
            public int I;
            // capacity of the parent
            public int C;
        }
    }
}
