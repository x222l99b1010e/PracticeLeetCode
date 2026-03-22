namespace PalindromeNumber
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello, World!");
		}
	}
	public class Solution
	{
		public bool IsPalindrome(int x)
		{
			if (x > int.MaxValue || x < int.MinValue || x < 0 || (x % 10 == 0 && x != 0))
			{
				return false;
			}
			else
			{
				int reversed = 0;
				while (x > reversed) 
				{
					reversed = reversed * 10 + x % 10;
					x/= 10;
				}
				return x == reversed || x == reversed / 10;
			}
		}
		public bool IsPalindrome1(int x)
		{
			if (x > int.MaxValue || x < int.MinValue || x < 0 || (x % 10 == 0 && x != 0))
			{
				return false;
			}
			else
			{
				int reversed = 0;
				int original = x;
				while (x > 0) 
				{
					reversed = reversed * 10 + x % 10;
					x/= 10;
				}
				return reversed == original;
			}
		}
	}
}
