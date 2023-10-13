using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Build_Array_from_Permutation
{
    public class BuildArrayfromPermutation
    {
        public int[] BuildArray(int[] nums)
        {
            int n = nums.Length;
            int[] ans = new int[n];

            for (int i = 0; i < n; i++)
            {
                int item = nums[i];
                ans[i] = nums[item];
            }
            return ans;
        }
    }
}
