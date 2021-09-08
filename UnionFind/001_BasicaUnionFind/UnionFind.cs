using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_BasicaUnionFind
{
    public class UnionFind
    {
        int[] arr;
        public void Initialize(int n)
        {
            // arr[i] represent the group number of the element i.
            // initially we have n group named 0,1,...n-1
            arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = i;
            }
        }

        public void Group(int a, int b)
        {
            // Group1 => Group which contains the element a
            // Group2 => Group which contains the element b
            // merge the two group => Group1 and Group2
            // To merge we have two option,
            // a) all the elements of the Group2 can be moved to Group1 (or)
            // b) all the elements of the Group1 can be moved to Group2 (or)

            // here I am changing all the group1 elements to group2
            var group1 = arr[a];
            var group2 = arr[b];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == group1)
                {
                    arr[i] = group2;
                }
            }

            // To add 1 elements to group, time complexity is O(n)
            // To add n elements to group, time complexity is O(n^2)
        }
        public bool Find(int a, int b)
        {
            return arr[a] == arr[b];
            // To find if the two elements are in the same group, time complexity is O(1)
        }
    }
}
