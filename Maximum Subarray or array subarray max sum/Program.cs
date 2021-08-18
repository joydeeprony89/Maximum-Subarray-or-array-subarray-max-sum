
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
            int length = nums.Length;
            int currentMax = nums[0];
            int globalMax = nums[0];
            for (int i = 1; i < length; ++i)
            {
                if (currentMax < 0)
                {
                    currentMax = nums[i];
                }
                else
                    currentMax += nums[i];

                if (globalMax < currentMax)
                    globalMax = currentMax;
            }

            return globalMax;
        }
    }
}
