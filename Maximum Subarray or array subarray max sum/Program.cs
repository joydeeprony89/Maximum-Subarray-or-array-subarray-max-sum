
namespace Maximum_Subarray_or_array_subarray_max_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            var nums = new int[] { -4, 2, -5, 1, 2, 3, 6, -5, 1 }; // [-2,-9,-4,-1,0,-7,-5,-3]
            System.Console.WriteLine(p.MaxSubArray(nums));
        }

        public int MaxSubArray(int[] nums)
        {
            public class Solution {
                public int MaxSubArray(int[] nums) {
                  // dp array will have the possible max subarray sum at that current index, as the one element itself is a subarray of an array so at any position max subarray sum = Math.Max(nums[i], nums[i]+ dp[i -1]), current position item if is still maximum of subarraySum of nums[i]+dp[i-1](previous max which we have already calculated) 
                  int[] dp = new int[nums.Length];
                  dp[0] = nums[0];
                  int maxSum = dp[0];
                  for(int i = 1; i < nums.Length; i++){
                    int currentMaxSum = nums[i] + dp[i -1];
                    dp[i] = Math.Max(currentMaxSum, nums[i]);
                    maxSum = Math.Max(maxSum, dp[i]);
                  }

                  return maxSum;
                }
            }
        }
    }
}
