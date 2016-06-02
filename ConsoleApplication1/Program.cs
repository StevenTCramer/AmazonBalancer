using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
	class Program
	{
		static void Main(string[] args)
		{
			var data = new List<int> { 1000, 500, 200, 1, 5, 10, 50, 70, 70, 100 };
			var amazonBalancer = new AmazonBalancer(data);
			amazonBalancer.ProcessData();

			data = new List<int> { 1000, 500, 200, 100, 70, 70, 50, 10, 5, 1, 0, -100, -1000, -10000, -500, -300 };

			amazonBalancer = new AmazonBalancer(data);
			amazonBalancer.ProcessData();
			//amazonBalancer.Display();
		}
	}
}
