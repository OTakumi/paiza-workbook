using System;

class Programs
{
	static void Main()
	{
		var n = int.Parse(Console.ReadLine());

		var a = 0;
		for(var i=0; i < 1000; i++)
		{
			a = int.Parse(Console.ReadLine());
			Console.WriteLine(a);
		}
	}
}
