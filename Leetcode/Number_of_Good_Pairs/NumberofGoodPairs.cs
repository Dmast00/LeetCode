using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Number_of_Good_Pairs
{
    public class NumberofGoodPairs
    {

        public int NumIdenticalPairs(int[] nums)
        {
            int n = nums.Length;
            int count = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (nums[i] == nums[j] && j != i && i < j)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;

        }
    }
}
