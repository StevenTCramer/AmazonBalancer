namespace ConsoleApplication1
{
	using System;
	using System.Collections.Generic;
	using System.Diagnostics;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;


	class AmazonBalancer
	{
		public List<int> Data { get; }
		public List<int> List1 { get; }
		public List<int> List2 { get; }
		public int ArraySize => Data.Count / 2;
		public int List1Sum	 { get; set; }
		public int List2Sum { get; set; }
		public List<int> SortedList => Data.OrderByDescending(i =>  Math.Abs(i)).ToList();

		public AmazonBalancer(List<int> aList)
		{
			// Incoming list is supposed to have even number of elements
			Debug.Assert(aList.Count % 2 == 0);

			Data = aList;
			List1 = new List<int>();
			List2 = new List<int>();
		}

		public void ProcessData()
		{			
			foreach (var i in SortedList)
			{
				if( (List1Sum > List2Sum && i > 0 ) ||
						(List1Sum < List2Sum && i < 0 ) && 
						(List2.Count < ArraySize) ||
						List1.Count == ArraySize)
				{
					List2.Add(i);
					List2Sum += i;
				}
				else
				{
					List1.Add(i);
					List1Sum += i;
				}
				Display();
			}
		}

		public void Display()
		{
			Console.WriteLine($"List1: {String.Join(separator: ",", values: List1)}");
			Console.WriteLine($"List2: {String.Join(separator: ",", values: List2)}");
			Console.WriteLine($"List1Sum: {List1Sum}");
			Console.WriteLine($"List2Sum: {List2Sum}");
			Console.WriteLine($"List1.Count: {List1.Count}");
			Console.WriteLine($"List2.Count: {List2.Count}");
			Console.WriteLine(new String(c: '=', count: 25));
		}
	}
}

