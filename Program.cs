using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CounterProject {
	class Program {
		void Calculate() {
			for (int Counter = 2, Number = 1; Counter <= 10; Counter++) {
				Number *= Counter;
				Console.WriteLine($"The factorial of {Counter} is {Number}.");
			}
		}
		static void Main(string[] args) {
			new Program().Run();
		}
		void Run() {
			Calculate();
		}
	}
}
