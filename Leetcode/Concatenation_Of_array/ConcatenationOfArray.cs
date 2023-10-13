using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Concatenation_Of_array
{
    public  class ConcatenationOfArray
    {
        public int[] GetConcatenation(int[] nums)
        {
            int n = nums.Length;
            int[] ans = new int[2*n];
            //List<int> ans = new List<int>();

            
            for (int i = 0; i < n; i++)
            {
                ans[i] = nums[i];
                ans[i+n] = nums[i];
            }



            return ans;
        }
    }
}
