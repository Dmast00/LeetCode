// See https://aka.ms/new-console-template for more information


using Leetcode.Build_Array_from_Permutation;
using Leetcode.Concatenation_Of_array;
using Leetcode.Number_of_Good_Pairs;


#region objects
    ConcatenationOfArray getConcatenation = new ConcatenationOfArray();
    BuildArrayfromPermutation buildArrayfrom = new BuildArrayfromPermutation();
    NumberofGoodPairs numberofGood = new NumberofGoodPairs();
#endregion


#region variables
    int[] nums = { 1, 2, 3, 1, 1, 3 };
    
#endregion





Console.WriteLine(string.Join("\n",numberofGood.NumIdenticalPairs(nums)));