// 5つの整数の半角スペース区切りの入力 (paizaランク D 相当)

using System;

class Programs
{
	static void Main()
	{
		var input = Console.ReadLine().Split(' ');

		for(int i=0; i < 5; i++)
		{
			Console.WriteLine(input[i]);
		}
	}
}
