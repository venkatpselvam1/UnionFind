using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_ParentUnionFindMinTreeLength
{
    public class UnionFind
    {
        int[] arr;
        int[] weight;
        public void Initialize(int n)
        {
            arr = new int[n];
            weight = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = i;
                weight[i] = 1;
            }
        }

        public int FindRoot(int a)
        {
            while (arr[a] != a)
            {
                a = arr[a];
            }

            return a;
        }

        public void Group(int a, int b)
        {
            var r1 = FindRoot(a);
            var r2 = FindRoot(b);
            if (weight[r1] < weight[r2])
            {
                arr[r1] = r2;
                weight[r2] += weight[r1];
            }
            else
            {
                arr[r2] = r1;
                weight[r1] += weight[r2];
            }
        }

        public bool Find(int a, int b)
        {
            var r1 = FindRoot(a);
            var r2 = FindRoot(b);
            return r1 == r2;
        }
    }
}
