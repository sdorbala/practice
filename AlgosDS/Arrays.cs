//-----------------------------------------------------------------------------
// FoodDrop.cs
//-----------------------------------------------------------------------------

namespace AlgosDS.LeetCode {
    public static class Arrays {
        public static void Rotate<T>(this T[] nums, int k) {
            int n = nums.Length;
            int kPrime = k % n;

            Array.Reverse(nums, 0, n);
            Array.Reverse(nums, 0, kPrime);
            Array.Reverse(nums, kPrime, n - kPrime);
        }

        public static void Print<T>(this T[] nums) {
            Console.WriteLine($"Array is: {string.Join(",", nums)}");
        }

        public static int FindMin(int[] nums) {
            int n = nums.Length;
            if (nums[0] < nums[n - 1]) {
                return nums[0];
            }

            int start = 0, end = n - 1;
            while (end - start >= 2) {
                int mid = (end + start) / 2;
                if (nums[mid] < nums[start]) {
                    end = mid;
                }
                else if (nums[mid] > nums[end]) {
                    start = mid;
                }
            }
            return Math.Min(nums[start], nums[end]);
        }

        public static int CanCompleteCircuit(int[] gas, int[] cost) {
            // find index that maximizes the gas savings
            int startIndex = 0;
            int maxSaving = int.MinValue;

            for (int i = 0; i < gas.Length; i++) {
                int testNext = (i+1) % gas.Length;
                int curSaving = gas[i] - cost[i] + gas[testNext];
                if (curSaving > maxSaving) {
                    maxSaving = curSaving;
                    startIndex = i;
                }
            }
            Console.WriteLine($"startIndex = {startIndex}");

            int nextIndex = (startIndex + 1) % gas.Length;
            int gasLevel = gas[startIndex];
            int c = startIndex;
            while (nextIndex != startIndex) {
                Console.WriteLine($"gasLevel: {gasLevel}, cost: {cost[c]}");
                gasLevel = gasLevel - cost[c];
                if (gasLevel <= 0) {
                    return -1;
                }
                gasLevel = gasLevel + gas[nextIndex];
                c = (c + 1) % cost.Length;
                nextIndex = (nextIndex + 1) % gas.Length;
            }

            // last case. gas can be at 0 at the end
            gasLevel = gasLevel - cost[c];
            if (gasLevel < 0) {
                return -1;
            }

            return startIndex;
        }

    }
}
