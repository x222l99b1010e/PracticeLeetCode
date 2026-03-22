namespace TwoSum
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] nums = [2, 7, 11, 15];
			int target = 9;


		}

	}

	public class Solution
	{
		public int[] TwoSum(int[] nums, int target)
		{
			if (nums == null || nums.Length < 2 || nums.Length > 10000) return new int[0];
			Dictionary<int, int> dict = new Dictionary<int, int>();

			for (int i = 0; i < nums.Length; i++)
			{
				int remains = target - nums[i];
				int prevIndex;
				if (dict.TryGetValue(remains, out prevIndex))
				{
					return new int[] { i, prevIndex };
				}
				dict[nums[i]] = i;								
			}
			return new int[0];
		}
		public int[] TwoSum1(int[] nums, int target)
		{
			if (nums == null || nums.Length < 2 || nums.Length > 10000) return new int[0];
			for (int i = 0; i < nums.Length; i++)
			{
				int remains =target - nums[i];
				for (int j = i + 1; j <= nums.Length-1; j++)
				{
					if (remains == nums[j])
					{						
						return new int[] { i, j };
					}					
				}
			}
			return new int[0];
		}
	}
}
