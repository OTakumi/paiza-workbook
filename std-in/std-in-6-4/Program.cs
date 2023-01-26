using System;

class Program
{
	static void Main()
	{
		var n = int.Parse(Console.ReadLine());
		var input = Console.ReadLine().Split(' ');

		for(var i=0; i<n; i++)
		{
			Console.WriteLine(input[i]);
		}
	}
}
