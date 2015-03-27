using System;
class CallMethod2 {

	static int multiply2(int a) {
		return 2*a;
	}

	static void Main() {
		int input = int.Parse(Console.ReadLine());
		Console.WriteLine(multiply2(input));
		Console.ReadLine();
	}
}
