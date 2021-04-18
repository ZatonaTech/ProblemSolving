using problemSolving.problems;
using System;

namespace problemSolving
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Validate subsequence
            var res1 = ValidateSequence.IsValidSubsequence1(new int[] { 5, 1, 22, 25, 6, -1, 8, 10 }, new int[] { 1, 6, -1, 10 });
            Console.WriteLine(res1);
            var res2 = ValidateSequence.IsValidSubsequence2(new int[] { 5, 1, 22, 25, 6, -1, 8, 10 }, new int[] { 1, 6, -1, 10 });
            Console.WriteLine(res2);
            #endregion

        }
    }
}
