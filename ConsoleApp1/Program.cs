namespace recursiveFunctionTest
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Console.WriteLine("Hello, World!");
			int a = recursiveFunction(6, 2);
			int b = sum(9);
			Console.WriteLine(a);
			Console.WriteLine(b);
		}

		public static int recursiveFunction(int a, int b)
		{
			if (b == 1)
				return a;
			else
				return a + recursiveFunction(a, b - 1); ;
		}

		public static int sum(int n)
		{
			if (n == 1) return 1;
			else
				return n + sum(n - 1);
		}
	}
}
