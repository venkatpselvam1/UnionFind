using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_ParentUnionFind
{
    public class UnionFind
    {
        int[] arr;
        public void Initialize(int n)
        {
            arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                // arr[i] represent the parent of i.
                // arr[i] == i, this is root element. Initially all the elements are root.
                arr[i] = i;
            }
        }

        public int GetRoot(int a)
        {
            while (arr[a] != a)
            {
                a = arr[a];
            }
            return a;
        }

        public bool Find(int a, int b)
        {
            var r1 = GetRoot(a);
            var r2 = GetRoot(b);
            return r1 == r2;
        }

        public void Group(int a, int b)
        {
            var r1 = GetRoot(a);
            var r2 = GetRoot(b);
            arr[r1] = r2;
        }
    }
}
