using System;

class Program
{
    static void Main()
	{
		var s = Console.ReadLine();
		
		if(s == "baseball")
		{
			Console.WriteLine(9);
		} else if(s == "soccer")
		{
			Console.WriteLine(11);
		} else if(s == "rugby")
		{
			Console.WriteLine(15);
		} else if(s == "basketball")
		{
			Console.WriteLine(5);
		} else if(s == "volleyball")
		{
			Console.WriteLine(6);
		}
    }
}
