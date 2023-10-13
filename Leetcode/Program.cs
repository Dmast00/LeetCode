// See https://aka.ms/new-console-template for more information


using Leetcode.Build_Array_from_Permutation;
using Leetcode.Concatenation_Of_array;


#region objects
    ConcatenationOfArray getConcatenation = new ConcatenationOfArray();
    BuildArrayfromPermutation buildArrayfrom = new BuildArrayfromPermutation();
#endregion


#region variables
    int[] nums = {1, 3, 2, 1};
    
#endregion





Console.WriteLine(string.Join("\n",buildArrayfrom.BuildArray(nums)));