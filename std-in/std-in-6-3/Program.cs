using System;

class Program
{
	static void Main()
	{
		var input = Console.ReadLine().Split(' ');
		var n = int.Parse(input[0]);

		for(var i=1; i<n+1; i++)
		{
			Console.WriteLine(input[i]);
		}
	}
}
