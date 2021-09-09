using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_ParentUnionFindMinTreeLength
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * In the previous example, 
                    Assumption: A and B objects are connected only if root(A) == root(B).
                    Arr[i] represent the parent of i.
                    if arr[i] == i => it is root node
                But,
                    when Group two element(A and B), we have two choice,  
                        a) we can change the parent of A to B (or)
                        b) we can change the parent of B to A
                    It lead to a worst case scenario like long stack.
                        e.g. 0 -> 1 -> 2 -> 3 -> 4 -> 5 -> 6 -> 7 -> 8 -> 9

                So the idea is, we can give preference to size of capacity.
                if we want to have long list,           => we will join the long group to small group
                if we want to have short list,          => we will join the small group to large

                in this example, we want to keep the tree length as short as we can.
             */
            PerformExample();
        }
        public static void PerformExample()
        {
            var unionFind = new UnionFind();
            unionFind.Initialize(6);
            unionFind.Group(0, 1);
            unionFind.Group(1, 2);
            unionFind.Group(3, 2);
            PrintFind(3, 0, unionFind);
            PrintFind(4, 0, unionFind);
        }
        public static void PrintFind(int a, int b, UnionFind unionFind)
        {
            Console.WriteLine($" Unioned? ({a}, {b}) : " + unionFind.Find(a, b));
        }
    }
}
