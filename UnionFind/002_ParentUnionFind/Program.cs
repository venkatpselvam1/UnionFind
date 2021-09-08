using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_ParentUnionFind
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * In the previous example, 
                    Assumption: A and B objects are connected only if Arr[ A ] = Arr [ B ].
                    But it has the following time complexity,
                        Group => O(n^2)
                        Find => O(1)
            To bring one more improvement, instead of grouping them by changing the arr value to group name.
            We can assume that arr[i] represent parent of i.
            Suppose if arr[i] == i => it indicates the element is parent to itself. It can be called root.

            Initially all the elements will be root as arr[i] == i.
            To find the root, we will have while loop unless we find arr[i] == i

            To find if two nodes are connected, we see if their root are same or not.

            To connect element to another, we take root of first element and root of second element and connect the roots.
            To connect the roots, r1, r2 we can say arr[r1] = r2 (or) arr[r2] = r1
             */
            PerformExample();
        }
        public static void PerformExample()
        {
            var unionFind = new UnionFind();
            unionFind.Initialize(10);
            unionFind.Group(2, 1);
            unionFind.Group(4, 3);
            unionFind.Group(8, 4);
            unionFind.Group(9, 3);
            unionFind.Group(6, 5);
            PrintFind(9, 8, unionFind);
            PrintFind(9, 0, unionFind);
            PrintFind(6, 3, unionFind);
            PrintFind(6, 5, unionFind);
        }
        public static void PrintFind(int a, int b, UnionFind unionFind)
        {
            Console.WriteLine($" Unioned? ({a}, {b}) : " + unionFind.Find(a, b));
        }
    }
}
