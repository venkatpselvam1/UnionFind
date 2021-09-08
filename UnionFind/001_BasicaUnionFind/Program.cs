using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_BasicaUnionFind
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
Example: You have a set of elements S = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9}. Here you have 10 elements (N = 10 ).We can use an array Arr to manage the connectivity of elements. Arr[ ] indexed by elements of set, having size of N (as N elements in set) and can be used to manage the above operations.

Assumption: A and B objects are connected only if Arr[ A ] = Arr [ B ].

Now how we will implement above operations :

Find (A, B) - check if Arr[ A ] is equal to Arr[ B ] or not. Union (A, B) - Connect A to B and merge the components having A and B by changing all the elements ,whose value is equal to Arr[ A ], to Arr[ B ].
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
            Console.WriteLine($" Unioned? ({a}, {b}) : "+unionFind.Find(a, b));
        }
    }
}
