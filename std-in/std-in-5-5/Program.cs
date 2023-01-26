using System;

class Programs
{
	static void Main()
	{
		var input = Console.ReadLine().Split(' ');

		for(var i=0; i < 1000; i++)
		{
			Console.WriteLine(input[i]);
		}
	}
}
